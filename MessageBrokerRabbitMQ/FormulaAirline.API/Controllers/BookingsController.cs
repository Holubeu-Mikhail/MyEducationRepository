using FormulaAirline.API.Models;
using FormulaAirline.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaAirline.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ILogger<BookingsController> _logger;
    private readonly IMessageProducer _messageProducer;

    //in-memory db
    public static readonly List<Booking> Bookings = new List<Booking>();

    public BookingsController(ILogger<BookingsController> logger, IMessageProducer messageProducer)
    {
        _logger = logger;
        _messageProducer = messageProducer;
    }

    [HttpPost]
    public IActionResult CreateBooking(Booking newBooking)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        Bookings.Add(newBooking);
        _messageProducer.SendMessage<Booking>(newBooking);

        return Ok();
    }
}
