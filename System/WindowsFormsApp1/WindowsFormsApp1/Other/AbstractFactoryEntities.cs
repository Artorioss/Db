using System;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Other
{
    internal interface AbstractFactoryEntities
    {
        Employee createEmployee(int id, string lastName, string firstName, string surName, JobTitle jobTitle);
        Model createModel(int id, string name, decimal cost);
        Receipts createReceipts(int id, Model model, DateTime dateReceipt, int count, Employee employee);
        User createUser(int id, string name, string password, Employee employee);
        JobTitle createJobTitle(int id, string name);
        Goods createGoods(int id, string name, Model model);
    }
}
