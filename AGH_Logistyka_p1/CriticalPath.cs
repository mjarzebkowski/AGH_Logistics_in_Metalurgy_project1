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
        private CriticalPath nexTCriticalPath;
        private CriticalPath previousCriticalPath;

        //static CriticalPath getByID(int ID)
        //{

        //    //return 
        //}

        //DataTable CPM = (DataTable)BindingSource.

        //private int[] SetPossiblePatchs(CriticalPath elemCriticalPath)
        //{
        //    // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
        //    var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy); })
        //        select Int32.Parse(field);
        //    return possiblePachs = ints.ToArray();
        //}

        public void SetPossiblePatchs(CriticalPath elemCriticalPath)
        {
            // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
            var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy);
                })
                select Int32.Parse(field);
            possiblePachs = ints.ToArray();
        }

        //public void SetPossiblePatchs(CriticalPath elemCriticalPath)
        //{
        //    // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
        //    var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy);
        //        })
        //        select Int32.Parse(field);
        //    possiblePachs = ints.ToArray();
        //}

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

        private static CriticalPath[] WalkListAhead(CriticalPath[] list)
        {
            list[0].Eet = list[0].Est + list[0].t0;

            for (int i = 1; i < na; i++)
            {
                foreach (CriticalPath activity in list[i].Predecessors)
                {
                    if (list[i].Est < activity.Eet)
                        list[i].Est = activity.Eet;
                }

                list[i].Eet = list[i].Est + list[i].t0;
            }

            return list;
        }

        private static CriticalPath[] WalkListAback(CriticalPath[] list)
        {
            list[na - 1].Let = list[na - 1].Eet;
            list[na - 1].Lst = list[na - 1].Let - list[na - 1].t0;

            for (int i = na - 2; i >= 0; i--)
            {
                foreach (CriticalPath activity in list[i].Successors)
                {
                    if (list[i].Let == 0)
                        list[i].Let = activity.Lst;
                    else
                    if (list[i].Let > activity.Lst)
                        list[i].Let = activity.Lst;
                }

                list[i].Lst = list[i].Let - list[i].t0;
            }

            return list;
        }


        List<CPM_Element> _crcPath = new List<CPM_Element>();
        public static void CalculatePath(List<CriticalPath> projectList)
        {
            //projectList.ForEach(item => SetPossiblePatchs(item));

            foreach ( CriticalPath s in projectList )
            {
                s.SetPossiblePatchs(s);
                //s.possiblePachs.Max()

                int start = s.possiblePachs[0];
                int finish = s.possiblePachs[1];


                


                //s.Id;

            }
            
            //projectList.Sort(  );
            //weż element o najwyższym oczku
            //w których ścieżkach uczestniczy ?

            //foreach dla tych wszystkich ścieżek ustaw czas odpowiadających im t0, jeśl jest mniejszy niż ścieżka

            //powtórz w głąb, jeśli nie jeden

            // przelicz widoczność

        }














        //https://www.codeproject.com/Articles/25312/Critical-Path-Method-Implementation-in-C

        //public class Activity
        //{
        //    private string id; // Id
        //    private string description;
        //    private int duration; // t0
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
    }
}
