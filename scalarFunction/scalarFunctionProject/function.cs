using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
namespace scalarFunctionProject
{
    class function
    {
        public string name;
        public int numArguments;
        public string[] dataTypes;
        


        public function( string name, int numArguments, string[] dataType)
        {
            this.name = name;
            this.numArguments = numArguments;
            this.dataTypes=new string[dataType.Count()];
            for(int i=0;i<dataType.Count(); i++)
            {
                this.dataTypes[i] = dataType[i];
            }
           

        }
        public void writeFunction()
        {
            if (!File.Exists("function.xml")) //case file doesnot exist
            {
                XmlWriter writer = XmlWriter.Create("function.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("table");
                writer.WriteStartAttribute("name", "Function");
                //data of employee,id,name,salary,bonus,taxes,department,depId
                writer.WriteStartElement("function"); 
                writer.WriteStartElement("name");
                writer.WriteString(name);
                writer.WriteEndElement();
                //------------------------------------------------
                writer.WriteStartElement("numberofarguments");
               writer.WriteString(Convert.ToString(numArguments));
                writer.WriteEndElement();
                //--------------------------------------------------
                writer.WriteStartElement("dataTypes");
                for (int i = 0; i < dataTypes.Length; i++)
                {
                    writer.WriteStartElement("dataType");
                    writer.WriteString(dataTypes.ElementAt(i));
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
               //------------------------------------------------------
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                }
               else{
                XmlDocument doc = new XmlDocument();
                
                doc.Load("function.xml");
                XmlElement parent = doc.CreateElement("function");
                //------------------------------------------------
                XmlElement node = doc.CreateElement("name");
                node.InnerText=name;     
                parent.AppendChild(node);
                //------------------------------------------------
                node=doc.CreateElement("numberOfArguments");
                node.InnerText=Convert.ToString(numArguments);        
                parent.AppendChild(node);
                //------------------------------------------------
                node = doc.CreateElement("dataTypes");
                for (int i = 0; i < dataTypes.Count(); i++)
                {
                    XmlElement node1 = doc.CreateElement("dataType");
                    node1.InnerText = dataTypes.ElementAt(i);
                    node.AppendChild(node1);
                }
                parent.AppendChild(node);

                XmlElement root = doc.DocumentElement;
                root.AppendChild(parent);
                doc.Save("function.xml");
                }
        }
        static public void readFunctions()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("function.xml");
            XmlNodeList functionData = doc.GetElementsByTagName("function");

            for (int i = 0; i < functionData.Count; i++)
            {
                XmlNodeList functionChild = functionData[i].ChildNodes;
                string fName = functionChild[0].InnerText;
                int fNumArguments = Convert.ToInt32(functionChild[1].InnerText);
                XmlNodeList fDTypes = functionChild[2].ChildNodes;
                string[] dTypess=new string[fDTypes.Count];
                for (int j = 0; j < fDTypes.Count; j++)
                {
                    dTypess[j] = fDTypes[j].InnerText;

                }
                function tmp = new function(fName, fNumArguments, dTypess);
                globals.fnList.Add(tmp);
            }
        }
        
    }
}
