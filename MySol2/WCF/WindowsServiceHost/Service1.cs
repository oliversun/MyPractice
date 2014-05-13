using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;

namespace WindowsServiceHost
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost MyHost = null;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MyHost = new ServiceHost(typeof(ServiceLibrary.Service1));
            MyHost.Open();
        }

        protected override void OnStop()
        {
            if (MyHost != null)
                MyHost.Close();
        }
    }
}
