using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TesteApiNetCore_Swagger_v1.IServices;
using TesteApiNetCore_Swagger_v1.Models;

namespace TesteApiNetCore_Swagger_v1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudantesController : ControllerBase
    {
        IEstudanteService _estudanteService;

        public EstudantesController(IEstudanteService estudanteService)
        {
            _estudanteService = estudanteService;
        }

        // GET: api/Estudantes
        [HttpGet]
        public List<Estudante> Get()
        {
            return _estudanteService.Gets();
        }

        // GET: api/Estudantes/5
        [HttpGet("{id}", Name = "Get")]
        public Estudante Get(int id)
        {
            return _estudanteService.Get(id);
        }

        // POST: api/Estudantes
        [HttpPost]
        public List<Estudante> Post([FromBody] Estudante estudante)
        {
            return _estudanteService.Save(estudante);
        }

       
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public List<Estudante> Delete(int id)
        {
            return _estudanteService.Delete(id);
        }
    }
}
