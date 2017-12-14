using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    public class Activity
    {
        private string id;
        private string description;
        private int duration;
        private int est;
        private int lst;
        private int eet;
        private int let;
        private Activity[] successors;
        private Activity[] predecessors;

        private static Activity[] WalkListAhead(Activity[] list)
        {
            list[0].eet = list[0].est + list[0].duration;

            for (int i = 1; i < na; i++)
            {
                foreach (Activity activity in list[i].predecessors)
                {
                    if (list[i].est < activity.eet)
                        list[i].est = activity.eet;
                }

                list[i].eet = list[i].est + list[i].duration;
            }

            return list;
        }

        private static Activity[] WalkListAback(Activity[] list)
        {
            list[na - 1].let = list[na - 1].eet;
            list[na - 1].lst = list[na - 1].let - list[na - 1].duration;

            for (int i = na - 2; i >= 0; i--)
            {
                foreach (Activity activity in list[i].successors)
                {
                    if (list[i].let == 0)
                        list[i].let = activity.lst;
                    else
                    if (list[i].let > activity.lst)
                        list[i].let = activity.lst;
                }

                list[i].lst = list[i].let - list[i].duration;
            }

            return list;
        }

        void CriticalPath(Activity[] list)
        {
            Console.Write("\n          Critical Path: ");

            foreach (Activity activity in list)
            {
                if ((activity.eet - activity.let == 0) && (activity.est - activity.lst == 0))
                    Console.Write("{0} ", activity.id);
            }

            Console.Write("\n\n         Total duration: {0}\n\n", list[list.Length - 1].eet);
        }
    }
}
