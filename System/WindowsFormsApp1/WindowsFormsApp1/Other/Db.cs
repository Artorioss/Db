using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Other;
using WindowsFormsApp1.Modeles;
using System.Windows.Forms;
using System.Collections;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    internal class Db
    {
        private static SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-C1LLGAS;Initial Catalog=Фабрика (Лаб 2);Integrated Security=True");
        private static SqlCommand sqlCommand;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        private static DataTable table;

        private static Db db = new Db();

        public object Current => table;

        public static Db getInstance() 
        {
            return db;
        }

        Db() 
        {
            adapter = new SqlDataAdapter();
            openConnection();
        }

        public static void openConnection()
        {
            if (!connectionIsOpen()) sqlConnection.Open();
        }

        public static bool connectionIsOpen() 
        {
            bool result = false;
            if (sqlConnection.State == ConnectionState.Open) result = true;
            return result;
        }

        public static string getConnection()
        {
            return sqlConnection.WorkstationId;
        }

        public DataTable getAllRows(string name_table, string name_column_params = null, params object[] conditions)
        {
            string cmdText;
            if (conditions != null && conditions.Length != 0)
            {
                if (name_column_params == null)
                    cmdText = "SELECT * FROM " + $"{name_table}" + " WHERE";
                else
                    cmdText = "SELECT " + name_column_params + " FROM " + $"{name_table}" + " WHERE";
                foreach (object сondition in conditions)
                    cmdText += string.Format(" {0} AND", сondition);
                int length = cmdText.LastIndexOf("AND");
                if (length >= 0)
                    cmdText = cmdText.Substring(0, length);
            }
            else if (name_column_params == null) cmdText = "SELECT * FROM " + $"{name_table}";
            else cmdText = $"SELECT {name_column_params} FROM " + $"{name_table}";
            sqlCommand = new SqlCommand(cmdText, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return readData(reader);
        }

        public DataRow getUserData(string login, string password) 
        {
            string query = $"SELECT * FROM Пользователи WHERE Логин = '{login}' AND пароль = '{password}'";
            DataTable dataTable = createQueryForSelect(query);
            DataRow dataRow = null;
            if(dataTable.Rows.Count > 0) dataRow = dataTable.Rows[0];
            return dataRow;
        }

        public DataRow getEmployeeDataById(int id) 
        {
            string query = $"SELECT * FROM Сотрудники WHERE Код = {id}";
            return createQueryForSelect(query).Rows[0];
        }

        public DataRow getJobTitleDataById(int id) 
        {
            string query = $"SELECT * FROM Должности WHERE Код = {id}";
            return createQueryForSelect(query).Rows[0];
        }

        public DataRow getModelDataById(int id)
        {
            string query = $"SELECT * FROM Модели WHERE Код = {id}";
            return createQueryForSelect(query).Rows[0];
        }

        public DataRow getReceiptsDataById(int id)
        {
            string query = $"SELECT * FROM Поступления WHERE Код = {id}";
            return createQueryForSelect(query).Rows[0];
        }

        public bool insertReceipts(int idModel, DateTime dateTime, int count, int idEmployee) 
        {
            string query = $"INSERT INTO Поступления VALUES ({idModel}, '{dateTime}', {count}, {idEmployee})";
            return createQueryAndCheckExecute(query);
        }

        public bool updateReceipt(int id, int modelId, DateTime dateReceipt, int count, int employeeId)
        {
            string query = $"UPDATE Поступления SET [Код модели] = {modelId}, [Дата поступления] = '{dateReceipt}', [Кол-во] = '{count}', [Код принявшего сотрудника] = '{employeeId}'";
            return createQueryAndCheckExecute(query);
        }

        public bool deleteReceipt(int id) 
        {
            string query = $"DELETE FROM Поступления WHERE Код = {id}";
            return createQueryAndCheckExecute(query);
        }

        private bool createQueryAndCheckExecute(string cmdText)
        {
            sqlCommand = new SqlCommand(cmdText, sqlConnection);
            return sqlCommand.ExecuteNonQuery() >= 1 ? true : false;
        }

        private DataTable createQueryForSelect(string cmdText) 
        {
            sqlCommand = new SqlCommand(cmdText, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            return readData(reader);
        }

        private DataTable readData(SqlDataReader reader)
        {
            DataTable data = new DataTable();
            data.Load(reader);
            reader.Close();
            return data;
        }

        public void insertLOG(string login, DateTime date, int employeeId) 
        {
            string query = $"INSERT INTO Logs VALUES ('{login}', '{date}', {employeeId})";
            createQueryAndCheckExecute(query);
        }

        public void getAllLogs() 
        {
            string query = "SELECT * FROM Logs";
            createQueryForSelect(query);
        }
    }
}
