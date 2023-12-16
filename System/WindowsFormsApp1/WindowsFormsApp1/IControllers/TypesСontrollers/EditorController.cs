using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1.Controllers
{
    internal class EditorController : IController
    {
        IDbModel model;
        Form editingForm;

        public EditorController(IDbModel model, Form form) 
        {
            this.model = model;
           
        }

        public void closeView()
        {
            
        }
    }
}
