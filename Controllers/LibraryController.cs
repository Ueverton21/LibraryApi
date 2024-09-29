using Library.Communication.Request;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LibraryController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(Book),StatusCodes.Status200OK)]
    public IActionResult Create([FromBody] BookRequest book)
    {
        var newBook = new Book
        {
            Id = book.Id,
            Title = book.Title,
            Amount = book.Amount,
            Author = book.Author,
            Genre = book.Genre,
            Price = book.Price
        };
        return Created(string.Empty,newBook);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        List<Book> books = new List<Book>();
        return Ok(books);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult Update([FromBody] BookRequest book)
    {
        //Lógica de edição

        return Ok();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        //Lógica de exclusão
        return Ok();
    }
}
