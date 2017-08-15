using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vladko_s_notebook
{
    class Fighter
    {
        public static string Color { get; set; }
        public static string Name { get; set; }
        public static string Age { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public List<string> Oponents { get; set; }

        public double Rank(Fighter.Wins, Fighter.Loses)
        {
            return Wins + 1 / Loses + 1;
        }
    }
}
