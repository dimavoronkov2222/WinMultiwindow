using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WinMultiwindow.Core
{
    public class Good
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year_of_publication { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public string Return_date { get; set; }
        public string date_of_issue { get; set; }
        public string Price { get; set; }
        public Good() { }
        public Good(string name, string description, string price, string Year_of_publication, string Genre, string ISBN, string Return_date,string date_of_issue)
        {
            Name = name;
            Author = description;
            Year_of_publication = Year_of_publication;
            Genre = Genre;
            ISBN = ISBN;
            Return_date = Return_date;
            date_of_issue = date_of_issue;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Author}, {Year_of_publication},{Genre},{ISBN}, {Return_date},{date_of_issue}\t\t| {Price}$";
        }

    }
}
