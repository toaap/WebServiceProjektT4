using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceProjektWindowsFormApp
{
    class Controller
    {

        DataAccessLayer dal = new DataAccessLayer();

        public string GetFileContent(string filename)
        {
            return dal.GetFileContent(filename);
        }

        public List<string> GetAllApartments()
        {
            return dal.GetAllApartments();
        }

        //SQL DATA
        public DataTable GetEmployees()
        {
            return dal.GetEmployees();
        }

        public DataTable GetRelative()
        {
            return dal.GetRelative();
        }
        public DataTable GetEmployeeAbsence()
        {
            return dal.GetEmployeeAbsence();
        }

        public DataTable GetSickestEmployee()
        {
            return dal.GetSickestEmployee();
        }

        //SQL META
        public DataTable GetKeys()
        {
            return dal.GetKeys();
        }

        public DataTable GetIndexes()
        {
            return dal.GetIndexes();
        }

        public DataTable GetConstraints()
        {
            return dal.GetConstraints();
        }

        public DataTable GetAllTables()
        {
            return dal.GetAllTables();
        }

        public DataTable GetAllTables2()
        {
            return dal.GetAllTables2();
        }

        public DataTable GetEmployeesMeta()
        {
            return dal.GetEmployeesMeta();
        }

        public DataTable GetEmployeesMeta2()
        {
            return dal.GetEmployeesMeta2();
        }

        //---------------add/insert/delete/update

        public string[] GetEmployee(string id)
        {
            return dal.GetEmployee(id);
        }

        public void AddEmployee(string id, string firstName)
        {
            dal.AddEmployee(id, firstName);
        }

        public void DeleteEmployee(string id)
        {
            dal.DeleteEmployee(id);
        }

        public void UpdateEmployee(string id, string firstName)
        {
            dal.UpdateEmployee(id, firstName);
        }

    }
}
