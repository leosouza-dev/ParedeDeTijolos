using BTGPactual.IT.PME.Test.API.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BTGPactual.IT.PME.Test.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParedeDeTijolosController : ControllerBase
    {
        [HttpPost("cortar-tijolos")]
        public IActionResult CortarTijolos([FromBody] ParedeDTO paredeDTO)
        {
            try
            {
                var linhasDeTijolos = new List<LinhaDeTijolos>();
                foreach (var linha in paredeDTO.LinhasDeTijolos)
                {
                    var tijolos = new List<Tijolo>();
                    foreach (var tamanho in linha)
                    {
                        tijolos.Add(new Tijolo(tamanho));
                    }
                    linhasDeTijolos.Add(new LinhaDeTijolos(tijolos.ToArray()));
                }

                var parede = new Parede(linhasDeTijolos.ToArray());
                var resultado = parede.EncontrarMenorNumeroDeTijolosCortados();

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
