using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1
{
    public partial class FormAuthorization : Form, IObserver
    {
        IDbModel model;
        AuthorizationController controller;
        public FormAuthorization(IDbModel dbModel, IController controller)
        {
            InitializeComponent();
            model = dbModel;
            this.controller = (AuthorizationController)controller;
        }

        //TODO
        public void update()
        {
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            controller.tryEnterIntoSystem(textBoxLogin.Text, textBoxPassword.Text);
        }


    }
}
