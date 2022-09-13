using Microsoft.AspNetCore.Mvc;
using MiniProject1.Models;
using Newtonsoft.Json;

namespace MiniProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenderController : ControllerBase
    {
        

        [HttpPost("people")]
        public async Task <string> AddPeopleToList(PersonDTOList persons)

        {

            //listen med person objekter (navn, email, ip)
            
            var personList = persons.list;
            foreach (var person in personList)
            {
                var client = utils.GetClient("https://api.ipgeolocation.io/ipgeo?apiKey=7264fe99ad664eeaabeb67cf7394128d&ip=");
                var url = client.BaseAddress.ToString() + person.IP;
                var res = await client.GetAsync(url);
                var content = await res.Content.ReadAsStringAsync();
                var countryDTO = JsonConvert.DeserializeObject<CountryDTO>(content);

                var client2 = utils.GetClient("https://api.genderize.io/?name=");
                var url2 = client2.BaseAddress.ToString() + person.Name + "&country_id=" + countryDTO.Country;
                var res2 = await client2.GetAsync(url2);
                var content2 = await res2.Content.ReadAsStringAsync();
                var genderDTO = JsonConvert.DeserializeObject<GenderDTO>(content2);


            }



           

            //vi kalder getClient med ip URL for at finde geo lokation
            //vi skal bruge køn
            //var countryCode = utils.GetClient("url with ip");


            //vi kalder getClient med navn og landekode url, for at finde køn på person
            //
            //var gender = utils.GetClient("url with countrycode + name");



            return "okkk";
        }

        
        //https://ipapi.co/104.110.0.0/json/
        //https://api.genderize.io/?name=kim&country_id=US
    }
}