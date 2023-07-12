using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    public class Champions
    {
        public Champions(string name)
        {
            Name = name;       
        }
        public string Name { get; set; }
        

    }

    public class Roles
    {

        public Roles(string name, int sortIndex)
        {
            Name = name;
            SortIndex = sortIndex;
        }

        public string Name { get; set; }
        
        List<Champions> champions = new List<Champions>();
        public List<Champions> Champions { get => champions; set => champions = value; }
        public int SortIndex { get; set; }  
    }

}
