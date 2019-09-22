using DataTransferService.UseCases.Logger;
using System;
using System.ServiceProcess;
using System.Timers;

namespace DataTransferService
{
    public partial class TransferService : ServiceBase
    {
        Timer timer = new Timer();
        LoggerUseCase logger;
        public TransferService()
        {
            InitializeComponent();
            this.logger = new LoggerUseCase();
        }

        protected override void OnStart(string[] args)
        {
            logger.WriteToFile("Service is started at " + DateTime.Now);

            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 5000; //number in milisecinds  
            timer.Enabled = true;
        }

        protected override void OnStop()
        {
            logger.WriteToFile("Service is stopped at " + DateTime.Now);
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            logger.WriteToFile("Service is recall at " + DateTime.Now);
        }

    }
}
