using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SDV701Project2
{
    class clsJSONConnection
    {
        private static string URL = "http://localhost:8080/CafedesPensees/API/";

        protected static string APIURL
        {
            get{return URL;}
        }

        internal async static Task<List<clsOrders>> ViewOrders()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsOrders>>
            (await lcHttpClient.GetStringAsync(APIURL + "ViewOrders/"));
        }

        internal async static Task<List<clsBeansList>> ViewBeverages()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<clsBeansList>>
            (await lcHttpClient.GetStringAsync(APIURL + "ViewBeverages/"));
        }

        internal async static Task<clsBeans> ViewBeanCoffees(string prKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                using (var w = new WebClient())
                {
                    var lcJson = w.DownloadString(APIURL + "GetSelectedBean/" + prKey);
                    JsonSerializerSettings settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All
                    };

                    return JsonConvert.DeserializeObject<clsBeans>(lcJson, settings);
                }
            }
        }

        internal async static Task<bool> DeleteOrder(string prKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<bool>
                (await lcHttpClient.GetStringAsync(APIURL + "DeleteOrder/" + prKey));
        }

        internal async static Task<bool> DeleteCoffee(string prKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<bool>
                (await lcHttpClient.GetStringAsync(APIURL + "DeleteCoffee/" + prKey));
        }

        internal async static Task<int> AddCoffee(clsCoffees lcCoffee)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIURL + "AddCoffee/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string SerializedlcCoffee = JsonConvert.SerializeObject(lcCoffee);

                streamWriter.Write(SerializedlcCoffee);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                SortedList<string, string> list = new SortedList<string, string>();
                list = JsonConvert.DeserializeObject<SortedList<string, string>> (result);
                string lcID = list.Values[0];
                int IDToInt = int.Parse(lcID);
                return IDToInt;
            }
        }

        internal async static Task<string> EditCoffee(clsCoffees lcCoffee)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(APIURL + "EditCoffee/");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string SerializedlcCoffee = JsonConvert.SerializeObject(lcCoffee);

                streamWriter.Write(SerializedlcCoffee);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;

            }
        }

        internal async static Task<bool> LockToggle(string prTableName, int prKey, int prLockToggle)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<bool>
                (await lcHttpClient.GetStringAsync(APIURL + "LockRecord/" + prTableName + "/" + prKey + "/" + prLockToggle + "/"));
        }

        internal async static Task<int> CheckLockStatus(string prTableName, int prKey)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<int>
                (await lcHttpClient.GetStringAsync(APIURL + "CheckLockStatus/" + prTableName + "/" + prKey));
        }
    }
}
