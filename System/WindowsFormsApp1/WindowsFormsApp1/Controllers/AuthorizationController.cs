using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1.Controllers
{
    internal class AuthorizationController: AccessController
    {
        AbstractFactoryControllers factoryControllers;

        public AuthorizationController(IDbModel dbModel, AbstractFactoryControllers factoryControllers)
        {
            model = dbModel;
            formAuthorization = new FormAuthorization(model, this);
            formAuthorization.Show();
            this.factoryControllers = factoryControllers;
        }

        public void tryEnterIntoSystem(string login, string password) 
        {
            Entity user = model.createNewUserAndGet(login, password);
            if (user != null) 
            {
                model.insertLog();
                Program.run(factoryControllers.createSessionController(model, (User)user));
            } 
            else MessageBox.Show("Введены неверный пароль или логин!", "Доступ запрещен.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
