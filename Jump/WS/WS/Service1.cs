using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WS
{
    public partial class SW : ServiceBase
    {
        public SW()
        {
            InitializeComponent();
            if(!System.Diagnostics.EventLog.SourceExists("MySourse")){
                System.Diagnostics.EventLog.CreateEventSource("MySourse","MyNewLog");
            }
            eventLog1.Source = "MySourse";
            eventLog1.Log = "MyNewLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Incie!!");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Termine!!");
        }
    }
}
