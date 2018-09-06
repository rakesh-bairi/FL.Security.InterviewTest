using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FL.Security.InterviewTest.Controllers
{
    public class SecurityController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }



        public async Task<ActionResult> GetSecurities()
        {
            try
            {
                // We can Create Calling Odata API

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://www.fundslibrary.co.uk/FundsLibrary.DataApi.WebApi/");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", ConfigurationManager.AppSettings["SecurityKey"]);
                    HttpResponseMessage response = await client.GetAsync("Securities");
                    if (response.IsSuccessStatusCode)
                    {
                        // Return Deserialized response to Jquery Calling function
                        return await response.Content.ReadAsStringAsync<Product>();

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}