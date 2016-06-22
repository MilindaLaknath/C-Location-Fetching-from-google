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

            getLocationAddr(lat, lang);
            
        }

        public static String getLocationAddr(String lat,String lang)
        {
            String url = "http://maps.googleapis.com";
            String urlParams = "/maps/api/geocode/json?latlng=" + lat + "," + lang;

            var clientRest = new RestClient(new Uri(url));
            var clientRequst = new RestRequest(new Uri(url+urlParams));
            
            clientRequst.Method = Method.GET;
            clientRequst.RequestFormat = DataFormat.Json;

            RestResponse<RootObject> response = (RestResponse<RootObject>)clientRest.Execute<RootObject>(clientRequst);
            RootObject x = (RootObject)response.Data;
            //Console.WriteLine(x.results[0].formatted_address);

            return x.results[0].formatted_address;
        }

        
    }
}
