using Microsoft.AspNetCore.Mvc;
using testdocnet.Repositories;

namespace testdocnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IBookRepository _bookRepo;

        public ProductsController(IBookRepository repo)
        {
            _bookRepo = repo;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                return Ok(await _bookRepo.GetAllBooksAsync());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}

