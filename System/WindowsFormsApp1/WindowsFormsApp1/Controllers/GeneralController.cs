using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.Modeles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel;
using WindowsFormsApp1.IControllers.TypesСontrollers;

namespace WindowsFormsApp1.Controllers
{
    internal class GeneralController: WorkerController
    {

        public GeneralController(IDbModel model)
        {
            base.model = model;
            mainForm = new MainForm(this, model);
            model.registerFormObserver(mainForm);
            mainForm.Show();
        }
    }
}
