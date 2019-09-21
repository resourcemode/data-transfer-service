﻿using DataTransferService.Exceptions;
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
