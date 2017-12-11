using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGH_Logistyka_p1
{
    public class CriticalPath : CPM_Element
    {
        public static string criticalPathString { set; get; }
        public int startTime;
        private int[] possiblePachs;
        public byte view = 0;

        public int[] SetStartTime(CriticalPath elemCriticalPath)
        {
            // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
            var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy); })
                select Int32.Parse(field);
            return ints.ToArray();
        }

        int CalculateCpmElementStartTime(CriticalPath previousElement)
        {
            return previousElement.t0 + previousElement.startTime;
        }




        //List<CPM_Element> _crcPath = new List<CPM_Element>();
        public List<CPM_Element> CalculatePath(List<CPM_Element> projectList)
        {
            List<CPM_Element> crcPath = new List<CPM_Element>();






            return crcPath;
        }


        //https://www.codeproject.com/Articles/25312/Critical-Path-Method-Implementation-in-C

        //public class Activity
        //{
        //    private string id;
        //    private string description;
        //    private int duration;
        //    private int est;
        //    private int lst;
        //    private int eet;
        //    private int let;
        //    private Activity[] successors;
        //    private Activity[] predecessors;
 
        //        ...
        //}

















    }
}
