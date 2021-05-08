using System.IO;
using System.Net;
using bootstrap_cons_api.Models;
using Newtonsoft.Json;


namespace bootstrap_cons_api.Services
{
    public class ServicesDataResponse
    {

        public DataResponse GetDataResponse(string URL)
        {
            var requisition = WebRequest.CreateHttp(URL);
            requisition.Method = "GET";
            DataResponse dataResponse = new DataResponse();

            using (var response = requisition.GetResponse())
            {

                var streamData = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamData);
                object objResponse = reader.ReadToEnd();
                dataResponse = JsonConvert.DeserializeObject<DataResponse>(objResponse.ToString());
                streamData.Close();
                response.Close();
            }
            return dataResponse;
        }
    }
}