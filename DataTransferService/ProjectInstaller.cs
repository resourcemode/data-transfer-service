using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransferService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;


            this.serviceInstaller.Description = "This service is responsible for transferring abbyy exported data to database";
            this.serviceInstaller.DisplayName = "Transfer Service";
        }
    }
}
