using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProject.Model;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunlerimController : ControllerBase
    {
        Context context = new Context();

        [HttpGet("Getlist")]
        public IActionResult GetList()
        {
            List<Urun> urunlerim = new List<Urun>();
            urunlerim = context.Urunler.ToList();
            return Ok(urunlerim);
        }

        [HttpPost("Add")]
        public IActionResult Add(Urun urun)
        {
            context.Urunler.Add(urun);
            context.SaveChanges();  
            return Ok("işlem tamamlandı");
        }

        [HttpGet("Delete")]
        public IActionResult Delete(int id)
        {
            var urun= context.Urunler.FirstOrDefault(x => x.Id == id);
            context.Remove(urun);
            context.SaveChanges();
            return Ok("ürün silindi");
        }
    }
}
