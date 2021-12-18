using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Player
    {
        public string Name { get; set; }    
        public int Level { get; set; }
        public int HealPoints { get; set; }
        public List<Statistics> Statistics { get; set; }

    }
}
