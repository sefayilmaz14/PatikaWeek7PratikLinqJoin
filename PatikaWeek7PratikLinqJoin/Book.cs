using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek7PratikLinqJoin
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AutorId { get; set; }


        public Book(int bookid, string title, int autorid)
        {
            BookId = bookid;
            Title = title;
            AutorId = autorid;
        }
    }
}
