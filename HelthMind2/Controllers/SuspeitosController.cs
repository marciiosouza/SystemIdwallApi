using SystemIdwallApi.Context;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;




namespace SystemIdwallApi.Model

{
    [Route("api/[controller]")]
    [ApiController]
    public class SuspeitosController : ControllerBase
    {
        private readonly SuspeitoRepository suspeitoRepository;

        public SuspeitosController(DataBaseContext dataBaseContext)
        {
            suspeitoRepository = new SuspeitoRepository(dataBaseContext);
        }

        [HttpGet]
        public ActionResult<List<SuspeitosModel>> Get()
        {
            try
            {
                var Lista = suspeitoRepository.ListarTodos();
                if (Lista != null)
                {
                    return Ok(Lista);

                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public ActionResult<SuspeitosModel> Post([FromBody] SuspeitosModel suspeitosModel)
        {
            try
            {
                suspeitoRepository.Inserir(suspeitosModel);
                var location = new Uri(Request.GetEncodedUrl() + "/" + suspeitosModel.SuspeitoId);
                return Created(location, suspeitosModel);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }

        
    }
}
