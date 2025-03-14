using MagicVilla_API.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        public  IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
            {
                new Villa { Id = 1, Nombre = "Vista a la Piscina" },
                new Villa { Id = 1, Nombre = "Vista a la Playa" }
            };
        }
    }
}