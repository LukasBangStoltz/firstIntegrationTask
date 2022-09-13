using MiniProject1;
using MiniProject1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Services;
using System.Xml.Linq;
using WebApplication1.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "test")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public async Task<List<EmailDTO>> HelloWorldAsync(PersonDTOList persons)
        {
            Console.WriteLine(persons);
            EmailListDTO emailListDTO = new EmailListDTO();
            var personList = persons.list;


            
           



            foreach (var person in personList)
            {


                using (var client = new WebClient())
                {
                    var responseString = client.DownloadString("https://api.ipgeolocation.io/ipgeo?apiKey=7264fe99ad664eeaabeb67cf7394128d&ip=" + person.IP);
                    var countryDTO = JsonConvert.DeserializeObject<CountryDTO>(responseString);





                responseString  = client.DownloadString("https://api.genderize.io/?name="+ person.Name + "&country_id=" + countryDTO.Country);
                  
                var genderDTO = JsonConvert.DeserializeObject<GenderDTO>(responseString);
                if (genderDTO.Gender == "male")
                {
                    genderDTO.Gender = "Mr.";
                }
                if (genderDTO.Gender == "female")
                {
                    genderDTO.Gender = "Ms.";
                }



                

                emailListDTO.EmailList.Add(new EmailDTO("Dear " + genderDTO.Gender + person.Name, "DUMMYBUDDY", "http://www.africau.edu/images/default/sample.pdf"));
                }
            }











            return emailListDTO.EmailList;
        }
    }
}
