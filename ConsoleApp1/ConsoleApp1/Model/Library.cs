using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Library
    {
        public string Name { get; set; }
        private List<LibraryItem> _items;

        public Library(string name) 
        {
            Name = name;
            _items = new List<LibraryItem>();
        }

        public List<LibraryItem> Items { 
            get { return _items; }
            private set { _items = value; }
        }

        public int ItemCount { get { return _items.Count; } }

        public void AddItem(LibraryItem item)
        { 
            _items.Add(item);
        }
        public LibraryItem FindByTitle(string title)
        {
            foreach (LibraryItem item in _items)
            {
                if (item.Title == title)
                {
                    return item;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        public List<LibraryItem> AvailableItems()
        {
            List<LibraryItem> list = new List<LibraryItem>();
            foreach (LibraryItem item in _items)
            {
                if (item.IsAvailable)
                {
                    list.Add(item);
                }
            }
            return list;
        }

        public List<Book> Books()
        {
            List<Book> books = new List<Book>();
            foreach (LibraryItem item in books)
            {
                if (item.IsAvailable)
                {
                    books.Add(books);
                }
            }
            return books;
        }
    }
}
