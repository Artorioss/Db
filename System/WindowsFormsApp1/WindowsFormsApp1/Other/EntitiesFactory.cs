using System;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Other
{
    internal class EntitiesFactory : AbstractFactoryEntities
    {
        public Employee createEmployee(int id, string lastName, string firstName, string surName, JobTitle jobTitle)
        {
            return new Employee(id, lastName, firstName, surName, jobTitle);
        }

        public Goods createGoods(int id, string name, Model model)
        {
            return new Goods(id, name, model);
        }

        public JobTitle createJobTitle(int id, string name)
        {
            return new JobTitle(id, name);
        }

        public Model createModel(int id, string name, decimal cost)
        {
            return new Model(id, name, cost);
        }

        public Receipts createReceipts(int id, Model model, DateTime dateReceipt, int count, Employee employee)
        {
            return new Receipts(id, model, dateReceipt, count, employee);
        }

        public User createUser(int id, string name, string password, Employee employee)
        {
            return new User(id, name, password, employee);
        }
    }
}
