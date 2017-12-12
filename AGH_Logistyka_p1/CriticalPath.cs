using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGH_Logistyka_p1
{
    public class CriticalPath : CPM_Element
    {
        public static string criticalPathString { set; get; }
        public int startTime;
        private int[] possiblePachs;
        public byte view = 0;

        //DataTable CPM = (DataTable)BindingSource.

        private int[] SetPossiblePatchs(CriticalPath elemCriticalPath)
        {
            var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy); })
                select Int32.Parse(field);
            return possiblePachs = ints.ToArray();
        }

        //public int[] SetStartTime(CriticalPath elemCriticalPath)
        //{
        //    // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
        //    var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy); })
        //        select Int32.Parse(field);
        //    return ints.ToArray();
        //}

        int CalculateCpmElementStartTime(CriticalPath previousElement)
        {
            return previousElement.t0 + previousElement.startTime;
        }




        //List<CPM_Element> _crcPath = new List<CPM_Element>();
        //public static void CalculatePath(List<CriticalPath> projectList)
        //{
        //    foreach ( possiblePachs s in projectList)
        //    {
                
        //    }
        //    projectList[projectList.Count()].possiblePachs = SetPossiblePatchs();
                
                
        //        .possiblePachs.;

            //weż element o najwyższym oczku
            //w których ścieżkach uczestniczy ?

            //foreach dla tych wszystkich ścieżek ustaw czas odpowiadających im t0, jeśl jest mniejszy niż ścieżka

            //powtórz w głąb, jeśli nie jeden

            // przelicz widoczność

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


        //public static void CalculatePatch(object dataSource)
        //{
        //    throw new NotImplementedException();
        //}

        //public static int CountCRCElements()
        //{
        //    throw new NotImplementedException();
        //}
    //}
}
