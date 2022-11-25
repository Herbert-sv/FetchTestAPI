using FetchTestAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;
namespace FetchTestAPI.Controllers
{
    public class HomeController : Controller
    {
        
        public async Task<IActionResult> TestApi()
        {
          HttpClient client = new HttpClient();                                  
          var SenderObject =await client.GetStringAsync("https://localhost:44346/api/Example");
            List <ModelApiObject>? objects =  Newtonsoft.Json.JsonConvert.DeserializeObject<List<ModelApiObject>>(SenderObject);
           var objectss =objects.ToList();

            return View(objectss);
        }


    }  
}