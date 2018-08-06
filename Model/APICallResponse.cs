using System;
using System.Net;

namespace POSIDigitalPrinterAPIUtil.Model
{
    public class APICallResponse
    {
        public HttpStatusCode? StatusCode { get; set; }
        public String ResponseBody { get; set; }
    }
}
