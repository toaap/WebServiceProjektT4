using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceProjektWindowsFormApp.ServiceReferenceCsharp;
using WebServiceProjektWindowsFormApp.Utils;

namespace WebServiceProjektWindowsFormApp

{
    class DataAccessLayer
    {
        ServiceReferenceCsharp.WebServiceCsharpSoapClient client = new ServiceReferenceCsharp.WebServiceCsharpSoapClient();

        public string GetFileContent(string filename)
        {
            return client.GetFileContent(filename);
        }

        public List<string> GetAllApartments(){


            Apartment[] apsList = null;

            try
            {
                apsList = client.GetAllApartments();
            }
            catch (Exception)
            {
                throw new ErrorException("Soap krasha");
            }
                List<string> apartmentList = new List<string>();

                if (apsList != null)
                {
                    foreach (Apartment ap in apsList)
                    {
                        apartmentList.Add(ap.ApartmentNr);
                    }
                }

                return apartmentList;
            
           

        }


        //MÅSTE NULL CHECKA!!
        public DataTable ListConvert(ArrayOfString[] array)
        {
            DataTable tb = new DataTable();
            tb.Clear();

            for (int k = 0; k < array[0].Count; k++)
            {
                tb.Columns.Add(k.ToString());

            }

            foreach (ArrayOfString a in array)
            {
                int rowcount = 0;

                DataRow row = tb.NewRow();

                for (int i = 0; i < a.Count; i++)
                {
                    row[rowcount] = a[i];
                    rowcount++;
                }
                tb.Rows.Add(row);
            }

            return tb;
            
        }

        //SQL DATA
        public DataTable GetEmployees()
        {
            ArrayOfString[] array = client.GetEmployees();
            return ListConvert(array);
           
        }

        public DataTable GetRelative()
        {
            ArrayOfString[] array = client.GetRelative();

            return ListConvert(array);
        }

        public DataTable GetEmployeeAbsence()
        {
            ArrayOfString[] array = client.GetEmployeeAbsence();
            return ListConvert(array);
        }

        public DataTable GetSickestEmployee()
        {
            ArrayOfString[] array = client.GetSickestEmployee();
            return ListConvert(array);
        }

        //SQL META
        public DataTable GetKeys()
        {
            ArrayOfString[] array = client.GetKeys();

            return ListConvert(array);
        }

        public DataTable GetIndexes()
        {
            ArrayOfString[] array = client.GetIndexes();

            return ListConvert(array);
        }

        public DataTable GetConstraints()
        {
            ArrayOfString[] array = client.GetConstraints();

            return ListConvert(array);
        }

        public DataTable GetAllTables()
        {
            ArrayOfString[] array = client.GetAllTables();

            return ListConvert(array);
        }

        public DataTable GetAllTables2()
        {
            ArrayOfString[] array = client.GetAllTables2();

            return ListConvert(array);
        }

        public DataTable GetEmployeesMeta()
        {
            ArrayOfString[] array = client.GetEmployeesMeta();

            return ListConvert(array);
        }

        public DataTable GetEmployeesMeta2()
        {
            ArrayOfString[] array = client.GetEmployeesMeta2();
            return ListConvert(array);
        }

        //---------------add/insert/delete/update
        public string[] GetEmployee(string id)
        {
            
            Employee e1 = client.GetEmployee(id);

            string[] empArray = new string[2];

            if (e1 != null)
            {
                empArray[0] = e1.id;
                empArray[1] = e1.firstName;
            }
            
            return empArray;
        }

        public void AddEmployee(string id, string firstName)
        {
            client.AddEmployee(id, firstName);
        }

        public void DeleteEmployee(string id)
        {
            client.DeleteEmployee(id);
        }

        public void UpdateEmployee(string id, string firstName)
        {
            client.UpdateEmployee(id, firstName);
        }


        

       
    }
}
