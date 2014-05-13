using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppClinet
{
    class Program
    {
        static void Main(string[] args)
        {
            //tcp模式安全加密 密文传输 需要密码
            WCFService.Service1Client client = new WCFService.Service1Client("NetTcpBinding_IService1");
            client.ClientCredentials.Windows.ClientCredential.UserName = "RemoteClient";
            client.ClientCredentials.Windows.ClientCredential.Password = "qq100000000~";
            client.GetData(11);
            Console.WriteLine(client.GetData(11));
            client.Close();

            //tcp模式安全模式为None 密文传输不需要密码
            //WCFService.Service1Client client2 = new WCFService.Service1Client("NetTcpBinding_IService11");
            //client2.GetData(11);
            //Console.WriteLine(client2.GetData(11));
            //client2.Close();

            //basichttpbinding 安全模式为None,结果是明文传输，且不需要用户名和密码
            //WCFService.Service1Client client3 = new WCFService.Service1Client("BasicHttpBinding_IService1");
            //client3.GetData(11);
            //Console.WriteLine(client3.GetData(11));
            //client3.Close();

            //basichttpbinding 安全模式为，结果是明文传输，需要用户名和密码
            /*
               <basicHttpBinding>
                <binding 
                name="basicBindingConf">
                <security 
                mode="TransportCredentialOnly">
                <transport 
                clientCredentialType="Basic">
                </transport>
                </security>
                </binding>
                </basicHttpBinding>
             */
            // WCFService.Service1Client client4 = new WCFService.Service1Client("BasicHttpBinding_IService11");
            // client4.ClientCredentials.UserName.UserName = "RemoteClient";
            // client4.ClientCredentials.UserName.Password = "qq100000000~";
            // client4.GetData(11);
            // Console.WriteLine(client4.GetData(11));
            // client4.Close();

            // //悲剧的以上需要的用户名和密码是base64编码的在网络间传输
            //Console.WriteLine( Encoding.Default.GetString(Convert.FromBase64String("UmVtb3RlQ2xpZW50OnFxMTAwMDAwMDAwfg==")));

            // WCFService.Service1Client client5 = new WCFService.Service1Client("BasicHttpBinding_IService12");
            //client5.GetData(11);
            //Console.WriteLine(client5.GetData(11));
            //client5.Close();

            //basichttp 使用两个证书实现加密签名的安全传输
            //WCFService.Service1Client client6 = new WCFService.Service1Client("BasicHttpBinding_IService12");
            //Console.WriteLine(client6.GetData(11)); 
            //client6.Close();


            Console.ReadLine();
        }
    }
}
