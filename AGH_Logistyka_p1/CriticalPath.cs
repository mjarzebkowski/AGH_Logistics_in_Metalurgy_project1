using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CriticalPathMethod;

namespace AGH_Logistyka_p1
{
    public class CriticalPath : CPM_Element
    {
        public CriticalPath()
        {
            
        }

        public CriticalPath( Activity[] readyCRCList )
        {

        }



        public static string criticalPathString { set; get; }
        public int startTime;
        public int[] possiblePachs;
        public byte view = 0;
        private CriticalPath nexTCriticalPath;
        private CriticalPath previousCriticalPath;
        private Activity[] list;
        private static int na;
        
        public static Activity[] CastCrcPatchToActivityList( List<CriticalPath> CRCList )
        {
            if (CRCList.Count < 2)
            {
                na = CRCList.Count;
            }
            else
            {
                // not implemented
            }

            Activity[] list = new Activity[na];

            for (int i = 0; i < na; i++)
            {
                Activity activity = new Activity();
                activity.Id = CRCList[i].Id;
                activity.Description = CRCList[i].Name;
                activity.Duration = CRCList[i].t0;
                int np = CRCList[i].possiblePachs.Count();

                if (np != 0)
                {
                    activity.Predecessors = new Activity[np];

                    string id;

                    for (int j = 0; j < np; j++)
                    {
                        //Console.Write("    #{0} predecessor's ID: ", j + 1);
                        id = CRCList[i].possiblePachs[j].ToString();

                        Activity aux = new Activity();

                        if ((aux = aux.CheckActivity(list, id, i)) != null)
                        {
                            activity.Predecessors[j] = aux;

                            list[aux.GetIndex(list, aux, i)] = aux.SetSuccessors(aux, activity);
                        }
                        else
                        {
                            //Console.Beep();
                            //Console.Write("\n No match found! Try again.\n\n");
                            j--;
                        }
                    }
                }
                list[i] = activity;
            }

            return list;
        }


        public void SetPossiblePatchs(CriticalPath elemCriticalPath)
        {
            // ten potworek wyciąga wszystkie numery ścieżek oddzielone przecinkiem, z pola Name. Pomija śmieci
            var ints = from field in elemCriticalPath.Name.Split(',').Where((x) => { int dummy; return Int32.TryParse(x, out dummy);
                })
                select Int32.Parse(field);
            possiblePachs = ints.ToArray();
        }

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

        List<CPM_Element> _crcPath = new List<CPM_Element>();
        public static void CalculatePath(List<CriticalPath> projectList)
        {
            //projectList.ForEach(item => SetPossiblePatchs(item));

            foreach ( CriticalPath s in projectList )
            {

            }
        }



        //https://www.codeproject.com/Articles/25312/Critical-Path-Method-Implementation-in-C
    }
}
