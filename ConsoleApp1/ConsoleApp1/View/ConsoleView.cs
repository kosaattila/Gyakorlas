using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class ConsoleView
    {
        public void ShowItem(LibraryItem item)
        {
            Console.WriteLine(item.GetDescription());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
