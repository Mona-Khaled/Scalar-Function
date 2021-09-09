using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Microsoft.VisualBasic;

namespace scalarFunctionProject
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populate table combobox with table names////////////////////
            
            List<string> myTables = new List<string>();
            myTables.Add("Employee");
            myTables.Add("Service");
            this.combobxTableName.DataSource = myTables;
            this.combobxTableName.DropDownStyle = ComboBoxStyle.DropDownList;
            
            //read data from files////////////////////////////////////////

            employee.readEmployees();
            service.readServices();
            function.readFunctions();
            lblnoFn.Visible = false;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (globals.fnUsed == null)
            {
                lblnoFn.Visible = true;
                return;
            }
            else
                lblnoFn.Visible = false;
            switch (globals.fnUsed.name)
            {
                case "sum":
                    double result = sum();
                    textboxResult.Text = result.ToString();
                 break;

                case "average":
                 average();
                break;

                case "maximum":
               maximum();
                break;

                case "minimum":
                minimum();
               break;
       
                case "count":
                    string countValue = Interaction.InputBox("Enter the value that you want to count:", "welcome", "", 300, 200);
                        if(countValue!="")
                        {
                            count(countValue);
                        }
                break;

            }
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = false;
             if (globals.tableChosen == "Service")
            {
                showServiceData();
            }
            else if (globals.tableChosen == "Employee")
            {
                showEmpData();
            }
        }
        ////////////////////////////////////////////////////////////////////SHOWING DATA ON DATAGRID
        public void showEmpData()
        {
            DataTable empDt = new DataTable();
            if (empDt.Columns.Count == 0)
            {
                empDt.Columns.Add("ID");
                empDt.Columns.Add("Name");
                empDt.Columns.Add("Salary");
                empDt.Columns.Add("Bonus");
                empDt.Columns.Add("Department ID");
            }

            for (int i = 0; i < globals.emplist.Count; i++)
            {
                DataRow r = empDt.NewRow();
                r[0] = globals.emplist.ElementAt(i).id;
                r[1] = globals.emplist.ElementAt(i).name;
                r[2] = globals.emplist.ElementAt(i).salary;
                r[3] = globals.emplist.ElementAt(i).bonus;
                r[4] = globals.emplist.ElementAt(i).depId;
                empDt.Rows.Add(r);
            }
            dataGridViewTable.DataSource = empDt;
            
        }
       
        //----------------------
        public void showServiceData()
        {
            DataTable dt = new DataTable();
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Cost");
            }
            DataRow r = dt.NewRow();
            for(int i=0; i< globals.serviceList.Count;i++){
                r[0] = globals.serviceList.ElementAt(i).serviceId;
                r[1] = globals.serviceList.ElementAt(i).serviceName;
                r[2] = globals.serviceList.ElementAt(i).cost;
                dt.Rows.Add(r);
            }
            dataGridViewTable.DataSource = dt;

        }

        //FUNCTIONS BUTTONS////////////////////////////////////////////////////////////////////////
        private void btnSum_Click(object sender, EventArgs e)
        {
            btnSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            btnSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            for(int i=0;i<globals.fnList.Count;i++){
                if(globals.fnList.ElementAt(i).name=="sum"){
                    globals.fnUsed=globals.fnList.ElementAt(i);
                    break;
                }
            }
            getDataType(globals.fnUsed.dataTypes, globals.fnUsed.numArguments);
           
        }
        //--------------------------------

        private void btnMax_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < globals.fnList.Count; i++)
            {
                if (globals.fnList.ElementAt(i).name == "maximum")
                {
                    globals.fnUsed = globals.fnList.ElementAt(i);
                    break;
                }
            }
            getDataType(globals.fnUsed.dataTypes, globals.fnUsed.numArguments);
        }
        //------------------------------
        private void btnAverage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < globals.fnList.Count; i++)
            {
                if (globals.fnList.ElementAt(i).name == "average")
                {
                    globals.fnUsed = globals.fnList.ElementAt(i);
                    break;
                }
            }
            getDataType(globals.fnUsed.dataTypes, globals.fnUsed.numArguments);
        }

       
        //-------------------------------
        private void btnCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < globals.fnList.Count; i++)
            {
                if (globals.fnList.ElementAt(i).name == "count")
                {
                    globals.fnUsed = globals.fnList.ElementAt(i);
                    break;
                }
            }
            getDataType(globals.fnUsed.dataTypes, globals.fnUsed.numArguments);
        }
        //--------------------------------
        private void btnMin_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < globals.fnList.Count; i++)
            {
                if (globals.fnList.ElementAt(i).name == "minimum")
                {
                    globals.fnUsed = globals.fnList.ElementAt(i);
                    break;
                }
            }
            getDataType(globals.fnUsed.dataTypes, globals.fnUsed.numArguments);
        }


        //OUR FUNCTIONS/////////////////////////////////////////////////////////////
        public double sum() {

            double sum = 0;
            if (globals.tableChosen == "Employee")
            {
                if (globals.columnChosen == "Salary")
                    for (int i = 0; i < globals.emplist.Count; i++)
                        sum += globals.emplist.ElementAt(i).salary;


                else if (globals.columnChosen == "Bonus")
                    for (int i = 0; i < globals.emplist.Count; i++)
                        sum += globals.emplist.ElementAt(i).bonus;
            }

            else if (globals.tableChosen == "Service")
            {
                if (globals.columnChosen == "Cost")
                    for (int i = 0; i < globals.serviceList.Count; i++)
                        sum += globals.serviceList.ElementAt(i).cost;
            } 
            return sum;
            
        }
        //----------------------------
        public void average() {
            double s = sum();
            double a;
            if (globals.tableChosen == "Employee")
                a = s / globals.emplist.Count;
            else
                a = s / globals.serviceList.Count;
            textboxResult.Text = a.ToString();
        }
        //---------------------------
        public void maximum() {
            double max = -100;
            if (globals.tableChosen == "Employee")
            {
                if (globals.columnChosen == "Salary")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                       
                        if (globals.emplist.ElementAt(i).salary > max)
                        {
                            max = globals.emplist.ElementAt(i).salary;
                        }

                    }
                }
                else if (globals.columnChosen == "Bonus")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                        if (globals.emplist.ElementAt(i).bonus > max)
                        {
                            max = globals.emplist.ElementAt(i).salary;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Colum", MessageBoxIcon.Warning.ToString());
                }
            }
            else
            {
                if (globals.columnChosen == "Cost")
                {
                    for (int i = 0; i < globals.serviceList.Count; i++)
                    {
                        if (globals.serviceList.ElementAt(i).cost > max)
                        {
                            max = globals.serviceList.ElementAt(i).cost;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Colum", MessageBoxIcon.Warning.ToString());
                }
            }
            textboxResult.Text = max.ToString();
        }
        //-----------------------------------
        public void minimum()
        {
            double minVal = 99999999999999;
            if (globals.tableChosen == "Employee")
            {

                if (globals.columnChosen == "Salary")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)

                        if (minVal > globals.emplist.ElementAt(i).salary)
                        {
                            minVal = globals.emplist.ElementAt(i).salary;
                        }
                }
                else if (globals.columnChosen == "Bonus")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)

                        if (minVal > globals.emplist.ElementAt(i).bonus)
                        {
                            minVal = globals.emplist.ElementAt(i).bonus;

                        }
                }

                if (globals.tableChosen == "Service")
                {
                    if (globals.columnChosen == "Cost")
                    {
                        for (int i = 0; i < globals.serviceList.Count; i++)
                            if (minVal > globals.serviceList.ElementAt(i).cost)
                            {
                                minVal = globals.serviceList.ElementAt(i).cost;
                            }
                    }
                }
            }
            textboxResult.Text = minVal.ToString();
        }
        //---------------------------------
        public void count(string countChosen) {
            int countValue = 0;
            if (globals.tableChosen == "Employee")
            {
                if (globals.columnChosen == "Name")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                        if (countChosen == globals.emplist.ElementAt(i).name.ToString())
                        {
                            countValue++;
                        }
                    }
                }
                else if (globals.columnChosen == "Salary")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                        if (countChosen == globals.emplist.ElementAt(i).salary.ToString())
                        {
                            countValue++;
                        }
                    }
                }
                else if (globals.columnChosen == "Bonus")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                        if (countChosen == globals.emplist.ElementAt(i).bonus.ToString())
                        {
                            countValue++;
                        }
                    }
                }
                else if (globals.columnChosen == "Department ID")
                {
                    for (int i = 0; i < globals.emplist.Count; i++)
                    {
                        if (countChosen == globals.emplist.ElementAt(i).depId.ToString())
                        {
                            countValue++;
                        }
                    }
                }
            }
            else
            {
                if (globals.columnChosen == "Name")
                {
                    for (int i = 0; i < globals.serviceList.Count; i++)
                    {
                        if (countChosen == globals.serviceList.ElementAt(i).serviceName.ToString())
                        {
                            countValue++;
                        }
                    }
                }
                else if (globals.columnChosen == "Cost")
                {
                    for (int i = 0; i < globals.serviceList.Count; i++)
                    {
                        if (countChosen == globals.serviceList.ElementAt(i).cost.ToString())
                        {
                             countValue++;
                        }
                    }
                }
            }
            textboxResult.Text = Convert.ToString(countValue);
        }

        private void combobxTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //trying to display them in a diffrent  way
            globals.tableChosen = (combobxTableName.SelectedValue).ToString();

        }
        
        private void comboBoxColName_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            globals.columnChosen = (comboBoxColName.SelectedItem).ToString();
        }

        private void getDataType(string[] dType, int nArgs)
        {
            comboBoxColName.Items.Clear();
            
            for (int i = 0; i < nArgs; i++)
            {
                if (globals.fnUsed.name == "count")
                {
                    if (dType[i] == "String")
                    {
                        comboBoxColName.Items.Add("ID");
                        comboBoxColName.Items.Add("Name");
                    }
                    else if (dType[i] == "Double" && globals.tableChosen == "Employee")
                    {
                        comboBoxColName.Items.Add("Bonus");
                        comboBoxColName.Items.Add("Salary");
                    }
                    else if (dType[i] == "Double" && globals.tableChosen == "Service")
                        comboBoxColName.Items.Add("Cost");
                }


                else if (globals.fnUsed.name == "sum" || globals.fnUsed.name == "maximum" || globals.fnUsed.name == "minimum" || globals.fnUsed.name == "average")
                {
                    if (dType[i] == "Double" && globals.tableChosen == "Employee")
                    {
                        comboBoxColName.Items.Add("Bonus");
                        comboBoxColName.Items.Add("Salary");
                    }
                    else if (dType[i] == "Double" && globals.tableChosen == "Service")
                        comboBoxColName.Items.Add("Cost");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxColName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblnoFn.Visible = false;
        }
    }
}
