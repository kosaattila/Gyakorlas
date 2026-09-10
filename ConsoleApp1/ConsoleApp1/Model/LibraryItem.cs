using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class LibraryItem
    {
        public string Title { get; set; }

        public static int count;
        public bool IsAvailable { get; set; }

        public LibraryItem(string title) 
        {
            IsAvailable = true;
            Title = title;
            count++;
        }

        public bool Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Return()
        {
            IsAvailable = true;
        }

        public virtual string GetDescription()
        {
            return Title;
        }
    }
}
