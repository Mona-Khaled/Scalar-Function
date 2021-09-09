using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scalarFunctionProject
{
    class globals
    {
        static public List<employee> emplist = new List<employee>();
        static public List<service> serviceList = new List<service>();
        static public List<function> fnList = new List<function>();
        
        static public function fnUsed;
        static public string tableChosen;
        static public string columnChosen;
        static public string ColDataType;
    }
}
