using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;

namespace TencentCloud.Cmq.V20180920
{
    public class CmqClient : AbstractClient
    {
        private string endpoint="";

        public CmqClient(string endpoint, string version, Credential credential, string region, ClientProfile profile) : base(endpoint, version, credential, region, profile)
        {

        }
       
    }
}
