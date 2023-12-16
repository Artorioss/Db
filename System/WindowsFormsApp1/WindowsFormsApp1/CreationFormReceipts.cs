using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CreationFormReceipts : Form, IObserver
    {
        WorkerController controller;
        IDbModel model;
        DataTable modelsData;
        bool settingUpForm = true;

        public CreationFormReceipts(WorkerController controller, IDbModel model)
        {
            InitializeComponent();
            this.controller = controller;
            this.model = model;
        }

        public void setDataSourceInComboBox() 
        {
            modelsData = model.getDataTable();
            comboBoxModelNames.DataSource = modelsData;
            comboBoxModelNames.DisplayMember = "Наименование модели";
            comboBoxModelNames.ValueMember = "Код";
        }

        public void checkRequestStatus()
        {
            bool statusOK = model.getResultLastRequest();
            if (statusOK)
            {
                MessageBox.Show("Данные были добавлены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else MessageBox.Show("Не удалось добавить данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void update()
        {
            if (settingUpForm)
            {
                setDataSourceInComboBox();
                settingUpForm = false;
            }
            else checkRequestStatus();
        }

        private void buttonAddReceipts_Click(object sender, EventArgs e)
        {
            int idModel = Convert.ToInt32(comboBoxModelNames.SelectedValue);
            controller.addReceipts(idModel, (int)numericUpDownCountGoods.Value);

        }

        private void CreationFormReceipts_Load(object sender, EventArgs e)
        {
            controller.getModels();
        }
    }
}
