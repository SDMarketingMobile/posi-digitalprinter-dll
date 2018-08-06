using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public class AccountController : BaseController
    {
        public AccountController(string apiIP, int apiPort) : base(apiIP, apiPort) { }
        public AccountController() : base() { }

        // List accounts
        public async Task<List<Model.Account>> RetrieveAll()
        {
            try
            {
                List<Model.Account> accounts = await this.baseURLAPI
                .AppendPathSegment("accounts")
                .GetJsonAsync<List<Model.Account>>();

                if (accounts.Count > 0)
                {
                    for (var i = 0; i < accounts.Count; i++)
                    {
                        Model.Account account = accounts[i];

                        // TODO: corrigir o construtor do método
                        AccountItemController itemController = new AccountItemController();

                        account.Items = await itemController.RetrieveItemsByAccount(account);

                        accounts[i] = account;
                    }
                }

                return accounts;
            }
            catch (FlurlHttpException ex)
            {
                return null;
            }
        }
        
        // Create account
        public async Task<Model.APICallResponse> CreateAndSync(Model.Account Account)
        {
            Model.APICallResponse callResponse = new Model.APICallResponse();

            try
            {
                await this.baseURLAPI
                    .AppendPathSegment("accounts")
                    .PostJsonAsync(Account);
            }
            catch (FlurlHttpException ex)
            {
                callResponse.StatusCode = ex.Call.HttpStatus;
                callResponse.ResponseBody = ex.Call.Response.Content.ToString();
            }

            return callResponse;
        }
        
        // Get account items completed
        public async Task<List<Model.Account>> RetrieveWithItemsCompleted()
        {
            try
            {
                List<Model.Account> accounts = await this.baseURLAPI
                    .AppendPathSegment("accounts")
                    .AppendPathSegment("items")
                    .AppendPathSegment("completed")
                    .GetJsonAsync<List<Model.Account>>();

                return accounts;
            }
            catch (FlurlHttpException ex)
            {
                return null;
            }
        }

        // Check syncronized items
        public async Task<Model.APICallResponse> syncItems(List<Model.Account> Accounts)
        {
            Model.APICallResponse callResponse = new Model.APICallResponse();

            try
            {
                await this.baseURLAPI
                    .AppendPathSegment("accounts")
                    .AppendPathSegment("items")
                    .AppendPathSegment("sync")
                    .PutJsonAsync(Accounts);

                callResponse.StatusCode = HttpStatusCode.OK;
            }
            catch (FlurlHttpException ex)
            {
                callResponse.StatusCode = ex.Call.HttpStatus;
                callResponse.ResponseBody = ex.Call.Response.Content.ToString();
            }

            return callResponse;
        }
    }
}
