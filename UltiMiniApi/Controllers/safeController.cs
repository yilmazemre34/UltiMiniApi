using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UltiMiniApi.Entity;
using UltiMiniApi.Model;
using static System.Net.Mime.MediaTypeNames;

namespace UltiMiniApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class safeController : ControllerBase
    {
        

        [HttpGet]
        public  ActionResult<string> GetSafe()
        {
            using (var _db= new  UltiContext())
            {
                Safe kasa = _db.Safe.FirstOrDefault();
                string text = kasa.Name.ToString();
                return text;
            }

        }

    }
}
