using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scalarFunctionProject
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //string[] arr = { "Double" };
            //function sum = new function("sum", 1, arr);
            //sum.writeFunction();

            //string[] minArr = { "Double" };
            //function min = new function("minimum", 1, minArr);
            //min.writeFunction();

            //string[] maxArr = { "Double" };
            //function max = new function("maximum", 1, maxArr);
            //max.writeFunction();

            //string[] countArr = { "Double", "String" };
            //function count = new function("count", 1, countArr);
            //count.writeFunction();

            //string[] avgArr = { "Double" };
            //function avg = new function("average", 1, avgArr);
            //avg.writeFunction();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
