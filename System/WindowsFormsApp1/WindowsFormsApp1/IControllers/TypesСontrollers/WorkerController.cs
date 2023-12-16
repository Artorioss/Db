using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Modeles;

namespace WindowsFormsApp1.IControllers.TypesСontrollers
{
    public abstract class WorkerController : IController
    {
        protected MainForm mainForm;
        protected Form dialogForm;
        protected IDbModel model;
        public void closeView()
        {
            mainForm.Close();
        }

        public void getReceiptById(int id) 
        {
            model.loadReceiptById(id);
        
        }

        public void getLogs() 
        {
            model.loadAllLogsInTable();
        }

        public void getGoods()
        {
            model.loadAllGoodsInTable();
        }

        public void getReceipts()
        {
            model.loadAllReceiptsInTable();
        }

        public void getJobTitles()
        {
            model.loadAllJobTitlesInTable();
        }

        public void getModels()
        {
            model.loadAllModelsInTable();
        }

        public void getUsers()
        {
            model.loadAllUsersInTable();
        }

        public void getEmployees()
        {
            model.loadAllEmployeesInTable();
        }

        public void addReceipts(int idModel, int count) 
        {

            model.tryAddReceipt(idModel, count);
        }

        public void updateReceipts(Receipts entity) 
        {
            model.tryUpdateReceipt(entity);
        }

        public void deleteReceipts(int id)
        {
            model.tryDeleteReceipt(id);
        }

        public void showNewFormForCreatingReceipts() 
        {
            dialogForm = new CreationFormReceipts(this, model);
            model.registerFormObserver((CreationFormReceipts)dialogForm);
            dialogForm.ShowDialog();
            model.registerFormObserver(mainForm);
        }

        public void showNewFormForCreatingGood()
        {

        }
        public void showNewFormForCreatingJobTitle()
        {

        }
        public void showNewFormForCreatingModel()
        {

        }
        public void showNewFormForCreatingUser()
        {

        }
        public void showNewFormForCreatingEmployee()
        {

        }

        public void showNewFormForEditingReceipts(int id)
        {
            dialogForm = new EditingFormReceipts(this, model, id);
            model.registerFormObserver((EditingFormReceipts)dialogForm);
            dialogForm.ShowDialog();
            model.registerFormObserver(mainForm);
        }

        public void reshapingFormEditingReceipts(bool showInformation) 
        {
            if (showInformation == true)
            {
                dialogForm.Size = new System.Drawing.Size(611, 682);
                ((EditingFormReceipts)dialogForm).groupBox.Size = new System.Drawing.Size(565, 620);
                (dialogForm as EditingFormReceipts).groupBoxModel.Visible = true;
            }
            else 
            {
                dialogForm.Size = new System.Drawing.Size(611, 411);
                ((EditingFormReceipts)dialogForm).groupBox.Size = new System.Drawing.Size(565, 345);
                (dialogForm as EditingFormReceipts).groupBoxModel.Visible = false;
            }
        }
    }
}
