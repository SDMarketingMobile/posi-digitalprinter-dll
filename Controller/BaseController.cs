using Microsoft.Win32;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public class BaseController : IBaseController
    {
        private string API_IP;
        private int API_PORT;

        protected string baseURLAPI;

        /// <summary>
        /// Instantiate API controllers based on specified IP and PORT
        /// </summary>
        /// <param name="apiIP"></param>
        /// <param name="apiPort"></param>
        public BaseController(string apiIP, int apiPort)
        {
            this.API_IP = apiIP;
            this.API_PORT = apiPort;
            this.ConstructBaseURLAPI();
        }

        /// <summary>
        /// Instantiate API controllers based on Local Machine Registries
        /// HKEY_LOCAL_MACHINE\SOFTWARE\Posi\br.com.positecnologia.digitalprinter.api.ip
        /// HKEY_LOCAL_MACHINE\SOFTWARE\Posi\br.com.positecnologia.digitalprinter.api.port
        /// </summary>
        public BaseController()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Posi");

            if (key != null)
            {
                if (this.API_IP != null)
                {
                    this.API_IP = (string)key.GetValue("br.com.positecnologia.digitalprinter.api.ip");
                }
                else
                {
                    throw new Exceptions.RegistryNotFoundException("A chave [br.com.positecnologia.digitalprinter.api.ip] não foi encontrada!");
                }

                if (key.GetValue("br.com.positecnologia.digitalprinter.api.port") != null)
                {
                    this.API_PORT = (int)key.GetValue("br.com.positecnologia.digitalprinter.api.port");
                }
                else
                {
                    throw new Exceptions.RegistryNotFoundException("A chave [br.com.positecnologia.digitalprinter.api.ip] não foi encontrada!");
                }

                this.ConstructBaseURLAPI();
            }
            else
            {
                throw new Exceptions.RegistryNotFoundException("A chave [HKEY_LOCAL_MACHINE\\SOFTWARE\\Posi] não existe!");
            }
        }

        private void ConstructBaseURLAPI()
        {
            this.baseURLAPI = "http://" + this.API_IP + ":" + this.API_PORT;
        }

        public void UpdateBaseURLAPI(string apiIP, int apiPort)
        {
            this.API_IP = apiIP;
            this.API_PORT = apiPort;
            this.ConstructBaseURLAPI();
        }
    }
}
