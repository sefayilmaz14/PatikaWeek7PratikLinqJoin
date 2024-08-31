using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek7PratikLinqJoin
{
    public class Autor
    {
        public int AutorId { get; set; }
        public string Name { get; set; }

        public Autor(int autorid, string name)
        {
            AutorId = autorid;
            Name = name;
        }
    }
}
