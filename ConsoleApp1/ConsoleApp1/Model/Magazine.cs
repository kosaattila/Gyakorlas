using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        
        public Magazine(string title, int Issuenum) : base(title)
        {
            IssueNumber = Issuenum;
        }

        public override string GetDescription()
        {
            return $"asd {Title} {IssueNumber}";
        }
    }
}
