using System.Net;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public class AccountItemController : BaseController
    {
        public AccountItemController(string apiIP, int apiPort) : base(apiIP, apiPort) { }
        public AccountItemController() : base() { }

        /// <summary>
        /// Get account items
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<List<Model.AccountItem>> RetrieveItemsByAccount(Model.Account account)
        {
            List<Model.AccountItem> items = await this.baseURLAPI
                .AppendPathSegment("accounts")
                .AppendPathSegment(account.Id)
                .AppendPathSegment("items")
                .GetJsonAsync<List<Model.AccountItem>>();

            if(items.Count > 0) {
                for (var i = 0; i < items.Count; i++) {
                    Model.AccountItem accountItem = items[i];

                    // TODO: corrigir o construtor do metodo
                    AccountItemAditionalController aditionalController = new AccountItemAditionalController();

                    accountItem.Aditionals = await aditionalController.RetrieveAditionalsByItem(account, accountItem);

                    items[i] = accountItem;
                }
            }

            return items;
        }

        /// <summary>
        /// Check begining item preparation
        /// </summary>
        /// <param name="account"></param>
        /// <param name="accountItem"></param>
        /// <returns></returns>
        public async Task<Model.APICallResponse> reportBeginPreparation(Model.Account account, Model.AccountItem accountItem)
        {
            Model.APICallResponse callResponse = new Model.APICallResponse();

            try
            {
                await this.baseURLAPI
                    .AppendPathSegment("accounts")
                    .AppendPathSegment(account.Id)
                    .AppendPathSegment("items")
                    .AppendPathSegment(accountItem.Id)
                    .AppendPathSegment("begin")
                    .PutAsync(null);

                callResponse.StatusCode = HttpStatusCode.OK;
            }
            catch (FlurlHttpException ex)
            {
                callResponse.StatusCode = ex.Call.HttpStatus;
                callResponse.ResponseBody = ex.Call.Response.Content.ToString();
            }

            return callResponse;
        }

        /// <summary>
        /// Check ending item preparation
        /// </summary>
        /// <param name="account"></param>
        /// <param name="accountItem"></param>
        /// <returns></returns>
        public async Task<Model.APICallResponse> reportEndPreparation(Model.Account account, Model.AccountItem accountItem)
        {
            Model.APICallResponse callResponse = new Model.APICallResponse();

            try
            {
                await this.baseURLAPI
                    .AppendPathSegment("accounts")
                    .AppendPathSegment(account.Id)
                    .AppendPathSegment("items")
                    .AppendPathSegment(accountItem.Id)
                    .AppendPathSegment("end")
                    .PutAsync(null);

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
