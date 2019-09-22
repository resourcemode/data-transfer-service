using System.ComponentModel;

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
