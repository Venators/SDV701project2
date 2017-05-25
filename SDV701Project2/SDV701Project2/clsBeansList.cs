using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV701Project2
{
    [Serializable()]
    public class clsBeansList : SortedList<string, clsBeans>
    {
        public static SortedList<string, clsBeans> GetBeansList()
        {
            return SetBeansList().Result;
        }
        public async static Task<SortedList<string, clsBeans>> SetBeansList()
        {
            SortedList<string, clsBeans> lcBeansList;
            try
            {
                lcBeansList = await clsJSONConnection.ViewBeverages();
            }
            catch
            {
                lcBeansList = new SortedList<string, clsBeans>();
            }
            return lcBeansList;
        }
    }

}
