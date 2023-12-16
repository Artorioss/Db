using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;

namespace WindowsFormsApp1.Controllers
{
    internal class CommodityExpertController: WorkerController
    {
        public CommodityExpertController(IDbModel model)
        {
            base.model = model;
            mainForm = new MainForm(this, model);
            mainForm.tabPageEmployees.Parent = null;
            mainForm.tabPageJobTitles.Parent = null;
            mainForm.tabPageUsers.Parent = null;
            mainForm.tabPage1.Parent = null;
            model.registerFormObserver(mainForm);
            mainForm.Show();
        }

        
    }
}
