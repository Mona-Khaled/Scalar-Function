using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace scalarFunctionProject
{

    /// <summary>
    /// DATA TYPES OF EACH ATTRIBUTE IN A STATIC DICTIONARY<STRING ATTRINBUTENAME,STRING DATATYPE>  
    /// 
    /// </summary>
    public class employee
    {
        //static public Dictionary<string, string> dtypes;
        public string id { set; get; }
        public string name { set; get; }
        public double salary { set; get; }
        public double bonus { set; get; }
        public string depId { set; get; }

        public employee(string id,string name, double salary, double bonus,string depId)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.bonus = bonus;
            this.depId = depId;
            
        }
        public void inputEmployeeData()
        {

            if (!File.Exists("employee.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("employee.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "employee");
                //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("employee"); 
                writer.WriteStartElement("id");
                writer.WriteString(id);
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteStartElement("name");
               writer.WriteString(name);
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("salary");
                writer.WriteString(Convert.ToString(salary));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("bonus");
                writer.WriteString(Convert.ToString(bonus));
                writer.WriteEndElement();
                //--------------------------------------------------
                
                writer.WriteStartElement("depId");
                writer.WriteString(depId);
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else //case file already exist 
            {
               
                XmlDocument doc = new XmlDocument();
                
                doc.Load("employee.xml");
                XmlElement parent = doc.CreateElement("employee");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("id");
                node.InnerText=Convert.ToString(id);
                
                parent.AppendChild(node);
                //------------------------------------------------
                node=doc.CreateElement("name");
                node.InnerText=name;
               
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("salary");
                node.InnerText = Convert.ToString( salary);
                
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("bonus");
                node.InnerText = Convert.ToString( bonus);
                
                parent.AppendChild(node);
                //------------------------------------------------
               
                
                node = doc.CreateElement("depId");
                node.InnerText =Convert.ToString(depId);
                
                parent.AppendChild(node);
                //-------------------------------------------------
                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("employee.xml");
            }
        }


        static public void readEmployees()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                string id = child[0].Name;
                string idValue = child[0].InnerText;

                string name = child[1].Name;
                string nameValue = child[1].InnerText;

                string salary = child[2].Name;
                int salaryValue = Convert.ToInt32(child[2].InnerText);

                string bonus = child[3].Name;
                int bonusValue = Convert.ToInt32(child[3].InnerText);

                string depId = child[4].Name;
                string depIdValue = child[4].InnerText;

                employee emp = new employee(idValue, nameValue, salaryValue, bonusValue, depIdValue);
                globals.emplist.Add(emp);
            }
        }
    }
    


    }
