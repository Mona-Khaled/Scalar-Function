using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace scalarFunctionProject
{

    class service
    {
        public string serviceId { set; get; }
        public string serviceName { set; get; }
        public double cost { set; get; }

        

        public service(string serviceId, string serviceName, double cost)
        {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.cost = cost;
            
        }

        public void writeService()
        {
            if (!File.Exists("service.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("service.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "service");
                //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("service");
                writer.WriteStartElement("serviceId");
                writer.WriteString(serviceId);
                writer.WriteEndElement();
                //--------------------------------------------------

                writer.WriteStartElement("serviceName");
                writer.WriteString(serviceName);
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("cost");
                writer.WriteString(Convert.ToString(cost));
                writer.WriteEndElement();
                //--------------------------------------------------
               
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else //case file already exist 
            {

                XmlDocument doc = new XmlDocument();

                doc.Load("service.xml");
                XmlElement parent = doc.CreateElement("service");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("");
                node.InnerText = Convert.ToString(serviceId);
                
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("serviceName");
                node.InnerText = serviceName;
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("cost");
                node.InnerText = Convert.ToString(cost);
                
                parent.AppendChild(node);
                //------------------------------------------------
                
                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("service.xml");
            }
        }

        //read services

        static public void readServices()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("service.xml");
            XmlNodeList list = doc.GetElementsByTagName("service");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList child = list[i].ChildNodes;
                string serviceId = child[0].Name;
                string serviceIdValue = child[0].InnerText;

                string serviceName = child[1].Name;
                string serviceNameValue = child[1].InnerText;

                string cost = child[2].Name;
                int costValue = Convert.ToInt32(child[2].InnerText);
                service ser = new service(serviceIdValue, serviceNameValue, costValue);
                globals.serviceList.Add(ser);

            }
        }
    }



   
}

