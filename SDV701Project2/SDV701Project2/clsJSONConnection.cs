using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Runtime.Serialization;

namespace SDV701Project2
{
    class clsJSONConnection
    {
        internal async static Task<List<clsOrders>> ViewOrders()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrders>>
            (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewOrders/"));
        }

        internal async static Task<List<clsBeansList>> ViewBeverages()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsBeansList>>
            (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewBeverages/"));
        }

        internal async static Task<clsBeans> ViewBeanCoffees(string prKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                using (var w = new WebClient())
                {
                    var lcJson = w.DownloadString("http://localhost:8080/CafedesPensees/API/GetSelectedBean/" + prKey);
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };

                    return JsonConvert.DeserializeObject<clsBeans>(lcJson, settings);
                }
            }
        }

        /*internal async static Task<List<clsCoffees>> ViewCoffees(/*string prBeanID)
                {
                    var lcBeanID = '1';
                    using (HttpClient lcHttpClient = new HttpClient())
                        return JsonConvert.DeserializeObject<List<clsCoffees>>
                    (await lcHttpClient.GetStringAsync("http://localhost:8080/CafedesPensees/API/ViewCoffees/" + lcBeanID));
                }
            }*/
    }
}
