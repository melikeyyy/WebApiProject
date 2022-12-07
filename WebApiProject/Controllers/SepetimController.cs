using Microsoft.AspNetCore.Mvc;
using WebApiProject.Model;

namespace WebApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetimController : ControllerBase
    {
        Context context = new Context();

        [HttpGet("[action]")]
        public IActionResult GetList()
        {
            var result = context.Sepetim.ToList();
            return Ok(result);
        }

        [HttpPost("[action]")]
        public IActionResult Add(Sepet sepet)
        {
            context.Sepetim.Add(sepet);
            context.SaveChanges();
            return Ok("sepete ürün eklendi");
        }

        [HttpGet("[action]")]
        public IActionResult Delete(int id)
        {
            var result = context.Sepetim.Where(p => p.Id == id).FirstOrDefault() ;
            context.Sepetim.Remove(result);
            context.SaveChanges();

            var liste = context.Sepetim.ToList();
            return Ok(liste);
        }
    }
}
