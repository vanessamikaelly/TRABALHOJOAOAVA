using api_1.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_1.Controllers
{
    [Route("tarefa")]
    [ApiController]
    public class TarefaController : ControllerBase
    {

        List<Tarefa> listaTarefa = new List<Tarefa>();

        public TarefaController()
        {

            var tarefa1 = new Tarefa()
            {

                Id = 1,
                Descricao = "Estudo de API part 1"
            };

            var tarefa2 = new Tarefa()
            {

                Id = 2,
                Descricao = "Estudo de API part 2"
            };

            var tarefa3 = new Tarefa()
            {

                Id = 3,
                Descricao = "Estudo de API part 3"
            };

            listaTarefa.Add(tarefa1);
            listaTarefa.Add(tarefa2);
            listaTarefa.Add(tarefa3);

        }

        [HttpGet]

        public ActionResult GetTarefa()
        {
            return Ok(listaTarefa);

        }




        [HttpGet("id")]

        public IActionResult GetById(int id)
        {
            var tarefa = listaTarefa.Where(item => item.Id == id).FirstOrDefault();

            if (tarefa == null)
            {
                return NotFound();
            }

            return Ok(tarefa);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Tarefa item)
        {
            var tarefa = new Tarefa();

            tarefa.Id = item.Id;
            tarefa.Descricao = item.Descricao;
            tarefa.Feito = item.Feito;

            return StatusCode(StatusCodes.Status201Created, tarefa);
        }

        [HttpPut("(id)")]

        public IActionResult Put(int id, [FromBody] Tarefa item)
        {
            var tarefa = listaTarefa.Where(item => item.Id == id).FirstOrDefault();

            if (tarefa == null)
            {
                return NotFound();
            }
            
            tarefa.Descricao = item.Descricao;
            tarefa.Feito = item.Feito;

            return Ok(listaTarefa);
           
        }

        [HttpDelete ("{id}")]

        public IActionResult Delete(int id)
        {
            var tarefa = listaTarefa.Where(item => item.Id == id).FirstOrDefault();

            if (tarefa == null)
            {
                return NotFound();
            }

            listaTarefa.Remove(tarefa);

            return Ok(listaTarefa);

        }


        [HttpPost]
        public IActionResult Post([FromBody] Veiculo item)
        {

            var veiculo = new veiculo();


        }

        
       








    }


}
