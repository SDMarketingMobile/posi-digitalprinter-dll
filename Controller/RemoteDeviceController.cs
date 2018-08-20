using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using Ether.Network.Client;
using Ether.Network.Packets;
using Flurl;
using Flurl.Http;
using POSIDigitalPrinterAPIUtil.Socket;

namespace POSIDigitalPrinterAPIUtil.Controller
{
    public class RemoteDeviceController : BaseController
    {
        public RemoteDeviceController(string apiIP, int apiPort) : base(apiIP, apiPort) { }
        public RemoteDeviceController() : base() { }

        public new void UpdateBaseURLAPI(string apiIP, int apiPort)
        {
            base.UpdateBaseURLAPI(apiIP, apiPort);
        }

        /// <summary>
        /// List all remote devices
        /// </summary>
        /// <returns></returns>
        public async Task<List<Model.RemoteDevice>> RetrieveAll()
        {
            try
            {
                List<Model.RemoteDevice> remoteDevices = await this.baseURLAPI
                    .AppendPathSegment("remote")
                    .AppendPathSegment("devices")
                    .GetJsonAsync<List<Model.RemoteDevice>>();

                return remoteDevices;    
            }
            catch (FlurlHttpException)
            {
                return null;
            }
        }

        /// <summary>
        /// Charge database with remote devices data
        /// </summary>
        /// <param name="remoteDevices"></param>
        /// <returns></returns>
        public async Task<Model.APICallResponse> ReloadAll(List<Model.RemoteDevice> remoteDevices)
        {
            Model.APICallResponse callResponse = new Model.APICallResponse();

            try
            {
                await this.baseURLAPI
                    .AppendPathSegment("remote")
                    .AppendPathSegment("devices")
                    .AppendPathSegment("reload")
                    .PostJsonAsync(remoteDevices);
            }
            catch (FlurlHttpException ex)
            {
                callResponse.StatusCode = ex.Call.HttpStatus;
                callResponse.ResponseBody = ex.Call.Response.Content.ToString();
            }

            return callResponse;
        }

        /// <summary>
        /// Test connection with remote device
        /// </summary>
        /// <param name="remoteDevice"></param>
        /// <returns></returns>
        public bool TestConnection(Model.RemoteDevice remoteDevice)
        {
            bool connected = false;

            var client = new SocketClient(remoteDevice.DeviceIP, remoteDevice.DevicePort);
            client.Connect();

            connected = client.IsConnected;

            if(client.IsConnected)
            {
                client.Disconnect();
            }

            return connected;
        }
    }
}
