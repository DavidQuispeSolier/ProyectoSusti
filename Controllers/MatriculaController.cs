using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoSusti.Models;

namespace ProyectoSusti.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly ColegioContext _context;

        public MatriculaController(ColegioContext context)
        {
            _context = context;
        }

        // GET: api/customers

        [HttpGet(Name = "GetCustomer")]
        public List<Matricula> GetMatricula()
        {
            var response = _context.Matriculas.ToList();
            return response;

        }

        // Post: api/customers
        [HttpPost(Name = "Insertmatricula")]
        public void Insertmatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            _context.SaveChanges();
        }


    }
}
