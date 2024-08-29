using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static api_1.Controllers.TarefaController;

namespace api_1.Controllers
{
    [Route("/")]
    [ApiController]
    public class PrincipalController : ControllerBase
    {
        [HttpGet()]
        
        public ActionResult Get()
        {
            return Ok("API tarefas");

        }

        [HttpGet("hello-world")]

        public ActionResult GetHelloWorld()
        {
            return Ok("Hello World do Bruninho");



        }

        [HttpGet("autor")]

        public ActionResult GetAutor()
        {
            return Ok("vanessa");
        }


        
    }
}
