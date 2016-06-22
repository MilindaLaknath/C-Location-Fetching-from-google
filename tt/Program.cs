using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Net;
using System.IO;
using RestSharp;
using tt;

namespace tt
{
    class Program
    {
        static void Main(string[] args)
        {
            String lat = "6.908321";
            String lang = "79.917448";
            //String url = "http://maps.googleapis.com/maps/api/geocode/json";
            String urlParams = "?latlang=" + lat + "," + lang;

            getLocationAddr(lat, lang);
            
        }

        public static String getLocationAddr(String lat,String lang)
        {
            String url = "http://maps.googleapis.com";
            String urlParams = "/maps/api/geocode/json?latlng=" + lat + "," + lang;

            var clientRest = new RestClient(new Uri(url));
           // clientRest.BaseUrl = new Uri(url);

            var clientRequst = new RestRequest(new Uri(url+urlParams));
            //clientRequst.Resource = new Uri(urlParams);
            
            clientRequst.Method = Method.GET;
            clientRequst.RequestFormat = DataFormat.Json;

            RestResponse<RootObject> response = (RestResponse<RootObject>)clientRest.Execute<RootObject>(clientRequst);
            RootObject x = (RootObject)response.Data;
            Console.WriteLine(x.results[0].formatted_address);

           // IRestResponse<RootObject> clientResponse = clientRest.Execute<RootObject>(clientRequst);
           // System.IO.File.WriteAllText(@"C:\Users\Lahiru\Desktop\WriteText.txt", clientResponse.ToString());
            //Console.WriteLine(clientResponse.ToString());
            return "";
        }

        
    }
}
