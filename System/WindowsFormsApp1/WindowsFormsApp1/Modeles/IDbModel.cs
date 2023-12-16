using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1.Modeles
{
    public interface IDbModel
    {
        void registerFormAuthorizationObserver(IObserver observer);
        void removeFormAuthorizationObserver(IObserver observer);
        void notifyFormAuthorizationObservers();
        void registerFormObserver(IObserver observer);
        void removeFormObserver(IObserver observer);
        void notifyFormObserver();
        Entity createNewUserAndGet(string login, string password);
        Entity getUser();
        void loadAllLogsInTable();
        void loadAllGoodsInTable();
        void loadAllReceiptsInTable();
        void loadAllJobTitlesInTable();
        void loadAllEmployeesInTable();
        void loadAllModelsInTable();
        void loadAllUsersInTable();
        DataTable getDataTable();
        void tryAddReceipt(int idModel, int countGoods);
        void tryUpdateReceipt(Receipts entity);
        void tryDeleteReceipt(int id);
        bool getResultLastRequest();
        void loadReceiptById(int id);
        Entity getEntity();
        void insertLog();
    }
}
