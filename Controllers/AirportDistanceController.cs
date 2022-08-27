using CTeleportAssingment.Helpers;
using CTeleportAssingment.Models;
using Microsoft.AspNetCore.Mvc;

namespace CTeleportAssingment.Controllers;

[ApiController]
[Route("[controller]")]
public class AirportDistanceController : ControllerBase
{
    private readonly IAirportDetailsService _airportDetailsService;

    private readonly ILogger<AirportDistanceController> _logger;

    public AirportDistanceController(ILogger<AirportDistanceController> logger, IAirportDetailsService airportDetailsService)
    {
        _logger = logger;
        _airportDetailsService = airportDetailsService;
    }

    [HttpGet(Name = "GetDistance")]
    public async Task<double> Get(string formIATACode, string toIATACode)
    {
        var fromAirport = await _airportDetailsService.GetAirport(formIATACode);
        var toAirport = await _airportDetailsService.GetAirport(toIATACode);

        if (fromAirport == null)
        {
            throw new ArgumentNullException("From Airport can't be null");
        }

        if (toAirport == null)
        {
            throw new ArgumentNullException("To Airport can't be null");

        }

        var distance = fromAirport.Location?.Distance(toAirport.Location ?? new Location());
 
        return distance ?? 0d;
    }
}