using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebServiceProjektWindowsFormApp.ServiceReferenceCsharp;
using WebServiceProjektWindowsFormApp.Utils;

namespace WebServiceProjektWindowsFormApp
{
    public partial class CsharpView : Form
    {
        Controller controller = new Controller();

        ServiceReferenceCsharp.WebServiceCsharpSoapClient client = new ServiceReferenceCsharp.WebServiceCsharpSoapClient();

        public CsharpView()
        {
            InitializeComponent();

        }

        

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Fil (.txt)|*.txt";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label6.Text = "Sökväg: " + ofd.FileName;
                textBoxOpenFile.Text = controller.GetFileContent(ofd.FileName);
            }


            //try 
            //textBox1.Text = controller.GetFileContent(textBox1.Text);
            //catch soap ex -
                //try hämta felmeddelande
                //catch nätvärkkod
        }

        private void apartmentsBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> listComboBox1 = new Dictionary<string, string>();
            try
            {
                foreach (string aps in controller.GetAllApartments())
                {
                    listComboBox1.Add(aps, aps);
                }
            }
            catch (ErrorException ex)
            {
               label13.Text = ex.errorMessage;
            }

            apartmentsComboBox.DataSource = new BindingSource(listComboBox1, null);
            apartmentsComboBox.DisplayMember = "Value";
            apartmentsComboBox.ValueMember = "Key";

            apartmentsComboBox.SelectedIndex = 0;
        }

        private void cronusBtn_Click(object sender, EventArgs e)
        {

            //SQL DATA
            if (comboBoxCronus.SelectedValue == "0")
            {
                //Employee
                dataGridViewCronus.DataSource = controller.GetEmployees();
                dataGridViewCronus.Columns[0].HeaderText = "Nr";
                dataGridViewCronus.Columns[1].HeaderText = "Förstanamn";
                dataGridViewCronus.Columns[2].HeaderText = "Efternamn";
                dataGridViewCronus.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "1")
            {
                //Relatives
                dataGridViewCronus.DataSource = controller.GetRelative();
                dataGridViewCronus.Columns[0].HeaderText = "Nr";
                dataGridViewCronus.Columns[1].HeaderText = "Relation";
                dataGridViewCronus.Columns[2].HeaderText = "Släkting förnamn";
                dataGridViewCronus.Columns[3].HeaderText = "Anställd förnamn";
                dataGridViewCronus.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "2")
            {
                //Absence
                dataGridViewCronus.DataSource = controller.GetEmployeeAbsence();
                dataGridViewCronus.Columns[0].HeaderText = "Nr";
                dataGridViewCronus.Columns[1].HeaderText = "Orsak";
                dataGridViewCronus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "3")
            {
                //Sickest Employee
                dataGridViewCronus.DataSource = controller.GetSickestEmployee();
                dataGridViewCronus.Columns[0].HeaderText = "Namn";
                dataGridViewCronus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            //SQL META
            if (comboBoxCronus.SelectedValue == "4")
            {
                //Keys
                dataGridViewCronus.DataSource = controller.GetKeys();
                dataGridViewCronus.Columns[0].HeaderText = "Constraint name";
                dataGridViewCronus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "5")
            {
                //Indexes 
                dataGridViewCronus.DataSource = controller.GetIndexes();
                dataGridViewCronus.Columns[0].HeaderText = "Object id";
                dataGridViewCronus.Columns[1].HeaderText = "Name";
                dataGridViewCronus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "6")
            {
                //Constraints 
                dataGridViewCronus.DataSource = controller.GetConstraints();
                dataGridViewCronus.Columns[0].HeaderText = "Constraint name";
                dataGridViewCronus.Columns[1].HeaderText = "Table name";
                dataGridViewCronus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "7")
            {
                //All Tables
                dataGridViewCronus.DataSource = controller.GetAllTables();
                dataGridViewCronus.Columns[0].HeaderText = "Table name";
                dataGridViewCronus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "8")
            {
                //All Tables 2 
                dataGridViewCronus.DataSource = controller.GetAllTables2();
                dataGridViewCronus.Columns[0].HeaderText = "Table name";
                dataGridViewCronus.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "9")
            {
                //Employee Meta
                dataGridViewCronus.DataSource = controller.GetEmployeesMeta();
                dataGridViewCronus.Columns[0].HeaderText = "Table name";
                dataGridViewCronus.Columns[1].HeaderText = "Column name";
                dataGridViewCronus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (comboBoxCronus.SelectedValue == "10")
            {
                //Employee Meta 2
                dataGridViewCronus.DataSource = controller.GetEmployeesMeta2();
                dataGridViewCronus.Columns[0].HeaderText = "Table name";
                dataGridViewCronus.Columns[1].HeaderText = "Column name";
                dataGridViewCronus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
        void FillComboBoxCronus()
        {
            Dictionary<string, string> listComboCronus = new Dictionary<string, string>();
            //SQL DATA
            listComboCronus.Add("0", "Employee");
            listComboCronus.Add("1", "Relative");
            listComboCronus.Add("2", "Absence");
            listComboCronus.Add("3", "Sickest Employee");
            //SQL META
            listComboCronus.Add("4", "Meta - Keys");
            listComboCronus.Add("5", "Meta - Indexes");
            listComboCronus.Add("6", "Meta - Constraints");
            listComboCronus.Add("7", "Meta - All Tables");
            listComboCronus.Add("8", "Meta - All Tables 2");
            listComboCronus.Add("9", "Meta - Employee");
            listComboCronus.Add("10", "Meta - Employee 2");

            comboBoxCronus.DataSource = new BindingSource(listComboCronus, null);
            comboBoxCronus.DisplayMember = "Value";
            comboBoxCronus.ValueMember = "Key";

        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void CsharpView_Load(object sender, EventArgs e)
        {
            FillComboBoxCronus();
        }

        private void searchEmp_Click(object sender, EventArgs e)
        {
            if (idSearchTxtBox.Text != "")
            {
                string[] empList = controller.GetEmployee(idSearchTxtBox.Text);

                if (empList[0] != null)
                {
                    idSearchTxtBox.ReadOnly = true;
                    updateEmpBtn.Visible = true;
                    deleteEmployeeBtn.Visible = true;
                    firstNameSearchTxtBox.Text = empList[1];

                }
                else
                {
                    firstNameSearchTxtBox.Text = "Hittade inget";
                }
            }
            else
            {
                firstNameSearchTxtBox.Text = "Inget inskrivet";
            }
        }

        private void addEmp_Click_1(object sender, EventArgs e)
        {
            if (idAddEmptxtBox.Text != "" && firstNameAddEmpTxtBox.Text != "")
            {
                string id = idAddEmptxtBox.Text.Trim();
                string firstName = firstNameAddEmpTxtBox.Text.Trim();

                try
                {
                    controller.AddEmployee(id, firstName);
                }
                catch (Exception)
                {

                }
            }
        }

        private void updateEmpBtn_Click(object sender, EventArgs e)
        {
            controller.UpdateEmployee(idSearchTxtBox.Text, firstNameSearchTxtBox.Text);
        }

        private void deleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            controller.DeleteEmployee(idSearchTxtBox.Text);
            idSearchTxtBox.Text = "";
            firstNameSearchTxtBox.Text = "";

            idSearchTxtBox.ReadOnly = false;
            updateEmpBtn.Visible = false;
            deleteEmployeeBtn.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idSearchTxtBox.Text = "";
            firstNameSearchTxtBox.Text = "";

            idSearchTxtBox.ReadOnly = false;
            updateEmpBtn.Visible = false;
            deleteEmployeeBtn.Visible = false;
        }

    }
}
