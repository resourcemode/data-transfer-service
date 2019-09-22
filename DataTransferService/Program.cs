using DataTransferService.Exceptions;
using DataTransferService.UseCases.Logger;
using System;
using System.Configuration.Install;
using System.Reflection;
using System.ServiceProcess;

namespace DataTransferService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                try
                {
                    LoanApplicationContext loanApplicationContext = new LoanApplicationContext();
                    ApplicationForm form = new ApplicationForm();
                    form.BusinessInformation_BusinessName = "Mike";
                    form.CaseId = Guid.NewGuid();
                    form.IsSigned = true;
                    form.Guarantor_IsPreviouslyGuarantorOfAnyLoan = true;
                    form.BusinessInformation_Sector = 1;
                    form.BusinessInformation_Category = 1;
                    form.BusinessInformation_BusinessType = 1;
                    form.BalanceSheet_DebtToEquityRatio = 1;
                    form.C_UpdatedBy = "michael.favila";
                    form.C_CreatedBy = "michael.favila";
                    form.C_CreatedAt = DateTime.Now;
                    form.C_CreatedAt = DateTime.Now;

                    loanApplicationContext.ApplicationForms.Add(form);
                    loanApplicationContext.SaveChanges();
                } catch (Exception e)
                {
                    LoggerUseCase useCase = new LoggerUseCase();
                    useCase.WriteToFile(e.Message);
                }

                InstallService(args);

                return;
            }

            RunService();
        }

        private static void InstallService(string[] args)
        {

            string parameter = string.Concat(args);
            switch (parameter)
            {
                case "--install":
                    ManagedInstallerClass.InstallHelper(new[] { Assembly.GetExecutingAssembly().Location });
                    break;
                case "--uninstall":
                    ManagedInstallerClass.InstallHelper(new[] { "/u", Assembly.GetExecutingAssembly().Location });
                    break;
                default:
                    throw new InvalidParameterException();
            }
        }

        private static void RunService()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new TransferService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
