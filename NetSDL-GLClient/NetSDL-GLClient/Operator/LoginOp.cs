using AmiBizSDK.Interface.Shell;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSDL_GLClient.Operator
{
    public class LoginOp:BaseManage
    {
        Logger log = LogManager.GetCurrentClassLogger();
        public int GetToken(string pjNO, string user, string pwd)
        {
            
            AmiBizSDK.Request.Shell.UserVerify request = new AmiBizSDK.Request.Shell.UserVerify();
            request.PjNo = pjNO;
            request.UserNo = user;
            request.UserPassword = pwd;
            AmiBizSDK.Response.Shell.UserVerify res = client.Execute(request);
            IUserVerify userVerify = res.Content;
            //设置token值
            LoginOp.token = userVerify.Token;
            if (res.ErrorCode != 0)
            {
                log.Error(res.ErrorMessage);
            }
            return res.ErrorCode;
        }

        public DataTable GetWareHouse()
        {
            DataTable dt = new DataTable();
            AmiBizSDK.Request.AppQuery.User.QyUserWh request = new  AmiBizSDK.Request.AppQuery.User.QyUserWh();
            string str=JsonConvert.SerializeObject(request);
            AmiApiSDK.Response.BaseTableResponse res = client.Execute(request);
            if (res.ErrorCode != 0)
            {
                log.Error(res.ErrorMessage);
            }
            dt = res.Content;
            return dt;
        }

        
    }
}
