﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;
namespace ProxyService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class ProxyService : IProxyService
    {
        DataManger dataManager;
        public ProxyService()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ProxyDbString"].ConnectionString;
            dataManager = new DataManger(connStr);
        }
        public void RegisterProxy(RegisterEntiy regInfo, string type)
        {
            switch (type)
            {
                case "HTTP":
                    dataManager.SaveToHttp(regInfo);
                    break;
                case "SOCKET":
                    dataManager.SaveToSocket(regInfo);
                    break;
                default:
                    break;
            }
        }

        public void HeartBeatMessage(HeartBeatEntity heartBeatInfo)
        {

        }

        public void CancelProxy(string ip,string port)
        {
            dataManager.DeleteProxy(ip, port);
        }
    }
}