using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SayHello(int userid);
        [OperationContract]
        User GetUser(int userid);
    }

    [DataContract]
    public class User 
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string UserName{get;set;}
    }

    
}
