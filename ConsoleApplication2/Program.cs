using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TweetSharp;


namespace ConsoleApplication2
{
    class Program
    {
        private static string cons_key = "v9hhw9Has5ggDVC63K3rnby1v";
        private static string cons_secret = "DoScc4lt710QGXdQPXqB7KiaN8QTkugRpAgnJhjmpFydkfdm4G";
        private static string access_token = "849806977760886785-w26rUBLGnBkFak7IWuT446O0M23zKOU";
        private static string secret_access = "necG42Cvstq5hNSdihMrqr4tcDsXpCrIwLV0wDM6Yg7f5";
        public static TwitterService twitter = new TwitterService(cons_key, cons_secret, access_token, secret_access);
        private static RootObject info;


        public static JObject getInfo()
        {
            WebRequest reqGet = WebRequest.Create("http://openapi.clearspending.ru/restapi/v3/contracts/search/?pricerange=1000000000-5000000000");
            WebResponse resp = reqGet.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            JObject parsed = JObject.Parse(s);
            return parsed;
        }

        static void Main(string[] args)
        {
            run();
        }
        public static void run()
        {
        Start:
            Console.WriteLine("input");
            JObject jp = getInfo();
            string json = jp.ToString();
            info = JsonConvert.DeserializeObject<RootObject>(json);
            try
            {
                foreach (var a in info.contracts.data)
                {
                    Console.WriteLine("S");
                    if (a.price >= 1000000000)
                        {
                            Console.WriteLine("A");
                            sendTweet("Был заключен контракт на сумму " + a.price.ToString() + " рублей между " + a.customer.shortName + " и " + a.suppliers[0].organizationName + "\nПодробнее: " + a.contractUrl + " и " + "https://clearspending.ru/contract/" + a.regNum);
                            Thread.Sleep(3000);
                        }       
                }
            }
            catch (Exception e)
            {

            }

            Console.WriteLine("1");
            goto Start;
        }

        public static void sendTweet(string _status)
        {
            twitter.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
            {

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("not OK");
                }
            });
        }
    }
}
