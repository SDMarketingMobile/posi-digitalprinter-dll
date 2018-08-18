using System;
using System.Collections.Generic;
using System.Text;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public interface IBaseController
    {
        void UpdateBaseURLAPI(string apiIP, int apiPort);
    }
}
