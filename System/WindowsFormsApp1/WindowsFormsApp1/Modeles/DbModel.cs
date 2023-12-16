using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controllers;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Other;

namespace WindowsFormsApp1.Modeles
{
    internal class DbModel : IDbModel
    {
        Db db = Db.getInstance();
        private AbstractFactoryEntities factoryEntities;
        List<IObserver> authorizationFormObservers = new List<IObserver>(1);
        IObserver formObserver;
        public DataTable dataTable { get; private set; }
        public bool resultLastRequest { get; private set; }
        public Entity entity { get; private set; }

        public Entity userWithSession { get; private set; }
        
        public DbModel(AbstractFactoryEntities abstractFactoryEntities) 
        {
            factoryEntities = abstractFactoryEntities;
        }

        public Entity getUser() 
        {
            return userWithSession;
        }
        
        public void registerFormAuthorizationObserver(IObserver observer)
        {
            authorizationFormObservers.Add(observer);
        }

        public void removeFormAuthorizationObserver(IObserver observer)
        {
            authorizationFormObservers.Remove(observer);
        }

        public void notifyFormAuthorizationObservers()
        {
            foreach (IObserver observer in authorizationFormObservers)
                observer.update();
        }

        public void registerFormObserver(IObserver observer)
        {
            formObserver = observer;
        }

        public void removeFormObserver(IObserver observer)
        {
            formObserver = null;
        }

        public void notifyFormObserver()
        {
            if (formObserver != null) formObserver.update();
        }


        public Entity createNewUserAndGet(string login, string password) 
        {
            Entity user = createSessionUser(login, password);
            userWithSession = user;
            return user;
        }

        private bool checkExistUser() 
        {
            bool exist = false;
            if (userWithSession != null) exist = true;
            return exist;
        }

        private Entity createSessionUser(string login, string password) 
        {
            DataRow userData = db.getUserData(login, password);
            Entity user = null;
            if (userData != null) 
                user = createUser((int)userData["Код"], (string)userData["Логин"], (string)userData["Пароль"], (int)userData["Код сотрудника"]);
            return user;
        }

        public void tryAddReceipt(int modelId, int countGoods) 
        {
            resultLastRequest = db.insertReceipts(modelId, DateTime.Now, countGoods, ((User)userWithSession).employee.id);
            notifyFormObserver();
        }

        public Entity getEntity() 
        {
            return entity;
        }

        public DataTable getDataTable() 
        {
            return dataTable;
        }

        public bool getResultLastRequest() 
        {
            return resultLastRequest;
        }

        public void loadAllGoodsInTable()
        {
            dataTable = db.getAllRows("Товары", null, null);
            notifyFormObserver();
        }

        public void loadAllReceiptsInTable()
        {
            dataTable = db.getAllRows("Поступления", null, null);
            notifyFormObserver();
        }

        public void loadAllJobTitlesInTable()
        {
            dataTable = db.getAllRows("Должности", null, null);
            notifyFormObserver();
        }

        public void loadAllEmployeesInTable()
        {
            dataTable = db.getAllRows("Сотрудники", null, null);
            notifyFormObserver();
        }

        public void loadAllModelsInTable()
        {
            dataTable = db.getAllRows("Модели", null, null);
            notifyFormObserver();
        }

        public void loadAllUsersInTable()
        {
            dataTable = db.getAllRows("Пользователи", null, null);
            notifyFormObserver();
        }

        public void loadReceiptById(int id) 
        {
            DataRow dateReceipts = db.getReceiptsDataById(id);
            entity = createReceipts(id, (int)dateReceipts["Код модели"], (DateTime)dateReceipts["Дата поступления"], (int)dateReceipts["Кол-во"], (int)dateReceipts["Код принявшего сотрудника"]);
            notifyFormObserver();
        }


        public Entity createUser(int id, string login, string password, int employeeId) 
        {
            DataRow dataEmployee = db.getEmployeeDataById(employeeId);
            DataRow dataJobTitle = db.getJobTitleDataById((int)dataEmployee["Код должности"]);
            Entity employee = createEmployee((int)dataEmployee["Код"], (string)dataEmployee["Фамилия"], (string)dataEmployee["Имя"], (string)dataEmployee["Отчество"], (int)dataJobTitle["Код"]);
            Entity user = factoryEntities.createUser(id, login, password, (Employee)employee);
            return user;
        }

        public Entity createEmployee(int id, string lastname, string firstname, string surname, int jobTitleId) 
        {
            DataRow dataJobTitle = db.getJobTitleDataById(jobTitleId);
            Entity jobTitle = createJobTitle((int)dataJobTitle["Код"], (string)dataJobTitle["Наименование"]);
            Entity employee = factoryEntities.createEmployee(id, lastname, firstname, surname, (JobTitle)jobTitle);
            return employee;
        }

        public Entity createGoods(int id, string name, int modelId) 
        {
            DataRow dataModel = db.getModelDataById(modelId);
            Entity model = createModel((int)dataModel["Код"], (string)dataModel["Наименование модели"], (decimal)dataModel["Цена модели"]);
            Entity goods = factoryEntities.createGoods(id, name, (Model)model);
            return goods;
        }

        public Entity createReceipts(int id, int modelId, DateTime dateReceipt, int count, int employeeId) 
        {
            DataRow dataModel = db.getModelDataById(modelId);
            DataRow dataEmployee = db.getEmployeeDataById(employeeId);
            Entity model = createModel((int)dataModel["Код"], (string)dataModel["Наименование модели"], (decimal)dataModel["Цена модели"]);
            Entity employee = createEmployee((int)dataEmployee["Код"], (string)dataEmployee["Фамилия"], (string)dataEmployee["Имя"], (string)dataEmployee["Отчество"], (int)dataEmployee["Код должности"]);
            Entity receipt = factoryEntities.createReceipts(id, (Model)model, dateReceipt, count, (Employee)employee);
            return receipt;
        }


        public Entity createJobTitle(int id, string name) 
        {
            return factoryEntities.createJobTitle(id, name);
        }

        public Entity createModel(int id, string name, decimal cost) 
        {
            return factoryEntities.createModel(id, name, cost);    
        }

        public void tryUpdateReceipt(Receipts entity)
        {
            resultLastRequest = db.updateReceipt(entity.id, entity.model.id, entity.dateReceipt, entity.count, entity.employee.id);
            notifyFormObserver();
        }

        public void tryDeleteReceipt(int id)
        {
            resultLastRequest = db.deleteReceipt(id);
            notifyFormObserver();
        }

        public void insertLog()
        {
            User user = userWithSession as User;
            db.insertLOG(user.Name, DateTime.Now, user.employee.id);
        }

        public void loadAllLogsInTable()
        {
            dataTable = db.getAllRows("Logs", null, null);
            notifyFormObserver();
        }
    }
}
