using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSDL_GLClient.Operator
{
    public  class BaseManage
    {
        protected int ret = 0;
        private string endPoint = string.Empty;
        private string cloudKey = string.Empty;
        private string secret = string.Empty;
        public static string token = string.Empty;
        
        private AmiApiSDK.Client.AmiApiClient _client = null;

        protected AmiApiSDK.Client.AmiApiClient client
        {
            get
            {
                this.endPoint = ConfigurationManager.AppSettings["AmiBizPath"];
                this.cloudKey = ConfigurationManager.AppSettings["AuthCloudKey"];
                this.secret = ConfigurationManager.AppSettings["AuthCloudSecret"];
                if (_client == null)
                {
                    _client = new AmiApiSDK.Client.AmiApiClient(endPoint, cloudKey, secret, token);
                }
                return _client;
            }
        }

          
    }
}
