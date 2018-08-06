using System;
using System.Collections.Generic;
using System.Text;

namespace POSIDigitalPrinterAPIUtil.Exceptions
{
    public class RegistryNotFoundException : Exception
    {
        public RegistryNotFoundException(String message) : base (message)
        {

        }
    }
}
