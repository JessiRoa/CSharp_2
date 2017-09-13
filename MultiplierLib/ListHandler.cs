using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("1");
            List.Add("2");
            List.Add("3");
            List.Add("4");
            List.Add("5");
        }
        /*for (i=1; i <= 6; i++)
         List add("test" +  i);*/

        public void RemoveThirdString()
        {
            List.Remove("2");
        }

        public void Sort()
        {
            //Console.WriteLine("{2}", List);
            List.Sort();
        }
    }
}
