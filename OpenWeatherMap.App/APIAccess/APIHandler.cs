using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace APIAccess
{
    public class APIHandler
    {
        string apiCall = @"http://api.openweathermap.org/data/2.5/forecast?id={CITYID}&units=metric&APPID=568a2ae7cb9790322d9f6e9f57945c98";

        public RootObject GetForecast(string cityID)
        {
            string callString = apiCall.Replace("{CITYID}", cityID);

            WebRequest request = WebRequest.Create(callString);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();

            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(responseFromServer);

            return rootObject;
        }
    }
}
