using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        private int _pageCount;

        public int PageCount
        {
            get { return _pageCount; }
            set {
                if (value < 0) 
                {
                    _pageCount = 0;       
                }
                else
                {
                    _pageCount = value;
                }
            }            
        }

        public Book(string title, string author, int pageCount) : base(title)
        {
            Author = author;
            PageCount = pageCount;
        }

        public Book(string title , string author) : this(title,author,0)
        {

        }

        public override string GetDescription()
        {
            return $"Title: {Title} - Author: {Author} - {PageCount}";
        }

        public bool IsLong()
        {
            return PageCount > 300;
        }
    }
}
