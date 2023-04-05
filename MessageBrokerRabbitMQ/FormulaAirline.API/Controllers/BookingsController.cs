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
    public static readonly List<Booking> Bookings = new List<Booking>()
    {
        new Booking()
        {
            Id = 0,
            PassengerName = "Mikhail",
            PassportNb = "1213412",
            From = "Minsk",
            To = "Moscow",
            Status = 0
        },
        new Booking()
        {
            Id = 1,
            PassengerName = "Victor",
            PassportNb = "09303213",
            From = "Berlin",
            To = "Paris",
            Status = 1
        },
        new Booking()
        {
            Id = 2,
            PassengerName = "Maxim",
            PassportNb = "28129321",
            From = "Los Angeles",
            To = "Las Vegas",
            Status = 2
        },
    };

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

    [HttpGet]
    public IActionResult GetBookings() 
    {
        return Ok(Bookings);
    }
}
