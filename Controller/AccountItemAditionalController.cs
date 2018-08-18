using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public class AccountItemAditionalController : BaseController
    {
        public AccountItemAditionalController(string apiIP, int apiPort) : base(apiIP, apiPort) { }
        public AccountItemAditionalController() : base() { }

        public new void UpdateBaseURLAPI(string apiIP, int apiPort)
        {
            base.UpdateBaseURLAPI(apiIP, apiPort);
        }

        /// <summary>
        /// Get account item aditionals
        /// </summary>
        /// <param name="account"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task<List<Model.AccountItemAditional>> RetrieveAditionalsByItem(Model.Account account, Model.AccountItem item)
        {
            List<Model.AccountItemAditional> aditionals = await this.baseURLAPI
                .AppendPathSegment("accounts")
                .AppendPathSegment(account.Id)
                .AppendPathSegment("items")
                .AppendPathSegment(item.Id)
                .AppendPathSegment("aditionals")
                .GetJsonAsync<List<Model.AccountItemAditional>>();

            return aditionals;
        }
    }
}
