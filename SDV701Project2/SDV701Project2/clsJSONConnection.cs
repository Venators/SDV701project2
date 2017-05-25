using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV701Project2
{
    class clsJSONConnection
    {
        /*internal async static Task<List<string>> ViewOrders()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewOrders/"));
        }*/

        internal async static Task<List<clsOrders>> ViewOrders()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrders>>
            (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewOrders/"));
        }

        internal async static Task<SortedList<string, clsBeans>> ViewBeverages()
        {
            try
            {
                var lcBeansList = new SortedList<string, clsBeans>();
                using (HttpClient lcHttpClient = new HttpClient())
                    return lcBeansList = JsonConvert.DeserializeObject<SortedList<string, clsBeans>>
                (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewBeverages/"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString());
            }
            return null;
        }

        internal async static Task<List<clsCoffees>> ViewCoffees(string prBeanID)
        {
            var lcBeanID = prBeanID;
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsCoffees>>
            (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewCoffees/" + prBeanID));
        }
    }

}
