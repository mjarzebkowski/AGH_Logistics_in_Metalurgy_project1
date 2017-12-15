using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGH_Logistyka_p1
{
    public class CPM_Element
    {
        public string Id
            {get{return Id;}set{Id = value;}}
        public string Name { get; set; } //nazwa 
        public int tc { get; set; }
        public int tm { get; set; }
        public int tp { get; set; }
        public int t0 { get; set; }
    }
}
