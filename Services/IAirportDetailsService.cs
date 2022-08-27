namespace CTeleportAssingment.Models
{
    public interface IAirportDetailsService
    {
        Task<Airport?> GetAirport(string IATACode);
    }
}