using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        private static IController controllerSession;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            AbstractFactoryControllers factoryControllers = new ControllerFactory();
            AbstractFactoryEntities abstractFactoryEntities = new EntitiesFactory();

            IDbModel dbModel = new DbModel(abstractFactoryEntities);
            //Создание контроллера и инициализация формы
            controllerSession = factoryControllers.createAuthorizationController(dbModel);

            Application.Run();
        }

        public static void run(IController controller) 
        {
            controllerSession.closeView();
            controllerSession = controller;
        } 
    }
}
