using BirtdayApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Formatting;
using System.Runtime.Serialization;

namespace BirtdayApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BirtdayController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<InviteModel> Katilanlar()
        {
            return Database.Liste.Where(i => i.State == true);
        }
        [HttpGet]
        public IEnumerable<InviteModel> Katilmayanlar()
        {
            return Database.Liste.Where(i => i.State == false);
        }
        [HttpPost]
        public void Ekle(InviteModel model)
        {
            if(ModelState.IsValid)
            {
                Database.Add(model);
            }
        }
    }
}
