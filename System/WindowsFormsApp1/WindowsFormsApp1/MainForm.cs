using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form, IObserver
    {
        WorkerController controller;
        IDbModel model;
        DataGridView dataGridView;


        public MainForm(WorkerController controller, IDbModel model)
        {
            InitializeComponent();
            this.controller = controller;
            this.model = model;
        }

        public void update()
        {
            dataGridView.DataSource = model.getDataTable();   
        }

        private void tabControlPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControlPagesLogs.SelectedTab;
            switch (tabPage.Name)
            {
                case "tabPageReceipts":
                    labelDate.Text = "Текущая дата: " + DateTime.Now.ToString();
                    dataGridView = dataGridViewReceipts;
                    controller.getReceipts();
                    break;
                case "tabPageGoods":
                    dataGridView = dataGridViewGoods;
                    controller.getGoods();
                    break;
                case "tabPageUsers":
                    dataGridView = dataGridViewUsers;
                    controller.getUsers();
                    break;
                case "tabPageJobTitles":
                    dataGridView = dataGridViewJobTitles;
                    controller.getJobTitles();
                    break;
                case "tabPageModels":
                    dataGridView = dataGridViewModels;
                    controller.getModels();
                    break;
                case "tabPageEmployees":
                    dataGridView = dataGridViewEmployees;
                    controller.getEmployees();
                    break;
                case "tabPage1":
                    dataGridView = dataGridViewLogs;
                    controller.getLogs();
                    break;
            }
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonAddReceipts_Click(object sender, EventArgs e)
        {
            controller.showNewFormForCreatingReceipts();
        }

        private void dataGridViewReceipts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.showNewFormForEditingReceipts(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
        }
    }
}
