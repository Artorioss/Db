using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.IControllers;
using WindowsFormsApp1.IControllers.TypesСontrollers;
using WindowsFormsApp1.Modeles;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1
{
    public partial class EditingFormReceipts : Form, IObserver
    {
        WorkerController controller;
        IDbModel model;
        int id;
        bool entityDataLoaded = false;
        bool dataLoadedInComboBoxModelNames = false;
        bool dataLoadedInComboBoxEmployeeNames = false;
        Receipts receipt;


        public EditingFormReceipts(WorkerController controller, IDbModel model, int id)
        {
            this.controller = controller;
            this.model = model;
            this.id = id;
            InitializeComponent();
        }
        
        //TODO!
        public DataTable convertTable(DataTable dataTable) 
        {
            // Создаем новый DataTable с двумя полями: "ФИО" и "Должность"
            DataTable modifiedDataTable = new DataTable();
            modifiedDataTable.Columns.Add("ФИО", typeof(string));
            modifiedDataTable.Columns.Add("Должность", typeof(string));

            // Копируем данные из исходного DataTable в новый DataTable
            foreach (DataRow originalRow in dataTable.Rows)
            {
                // Создаем новую строку для нового DataTable
                DataRow newRow = modifiedDataTable.NewRow();

                // Заполняем данные "ФИО"
                string fio = string.Format("{0} {1} {2}",
                    originalRow["Фамилия"],
                    originalRow["Имя"],
                    originalRow["Отчество"]);
                newRow["ФИО"] = fio;

                // Заполняем данные "Должность"
                newRow["Должность"] = originalRow["Код должности"];

                // Добавляем строку в новый DataTable
                modifiedDataTable.Rows.Add(newRow);
            }
            return modifiedDataTable;

        }

        //TODO!
        public void update()
        {
            if (!dataLoadedInComboBoxEmployeeNames)
            {
                comboBoxEmployeeNames.DataSource = convertTable(model.getDataTable());
                comboBoxEmployeeNames.DisplayMember = "ФИО";
                comboBoxEmployeeNames.ValueMember = "Должность";
                dataLoadedInComboBoxEmployeeNames = true;
            }
            else if (!dataLoadedInComboBoxModelNames)
            {
                comboBoxModelNames.DataSource = model.getDataTable();
                comboBoxModelNames.DisplayMember = "Наименование модели";
                comboBoxModelNames.ValueMember = "Цена модели";
                dataLoadedInComboBoxModelNames = true;
            }
            else if (!entityDataLoaded)
            {
                receipt = (Receipts)model.getEntity();
                receiptIdLabel.Text = "Код: " + receipt.id.ToString();
                modelIdLabel.Text = "Код модели: " + receipt.model.id.ToString();
                employeeIdLabel.Text = "Код принявшего сотрудника: " + receipt.employee.id.ToString();
                numericUpDownCountGoods.Value = receipt.count;
                monthCalendarDateReceipt.SelectionRange.Start = receipt.dateReceipt;

                labelModelCost.Text = receipt.model.cost.ToString();
                comboBoxModelNames.SelectedItem = receipt.model.name;
                comboBoxEmployeeNames.SelectedItem = receipt.employee.lastName + " " + receipt.employee.firstName + " " + receipt.employee.surName;
                entityDataLoaded = true;
            }
            else
            {
                if (model.getResultLastRequest())
                {
                    MessageBox.Show("Данные в таблице обновлены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Не удалось выполнить запрос", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void showAdditionaInformationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.reshapingFormEditingReceipts(showAdditionalInformationCheckBox.Checked);
        }

        private void EditingFormReceipts_Load(object sender, EventArgs e)
        {
            controller.getEmployees();
            controller.getModels();
            controller.getReceiptById(id);
        }

        private void groupBoxModel_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxModelNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelModelCost.Text = comboBoxModelNames.SelectedValue.ToString();
        }

        private void comboBoxEmployeeNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelEmployeeJobTitle.Text = comboBoxEmployeeNames.SelectedValue.ToString();
        }

        private void buttonEditReceipt_Click(object sender, EventArgs e)
        {
            controller.updateReceipts(receipt);
        }

        private void buttonDeleteReceipt_Click(object sender, EventArgs e)
        {
            controller.deleteReceipts(receipt.id);
        }
    }
}
