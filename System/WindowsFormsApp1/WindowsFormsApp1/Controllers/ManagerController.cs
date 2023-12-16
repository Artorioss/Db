using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;

namespace WindowsFormsApp1.Controllers
{
    internal class ManagerController: WorkerController
    {

        public ManagerController(IDbModel model)
        {
            base.model = model;
            mainForm = new MainForm(this, model);
            mainForm.tabPageEmployees.Parent = null;
            mainForm.tabPageJobTitles.Parent = null;
            mainForm.tabPageReceipts.Parent = null;
            mainForm.tabPageUsers.Parent = null;
            mainForm.tabPage1.Parent = null;
            model.registerFormObserver(mainForm);
            mainForm.Show();
        }
    }
}
