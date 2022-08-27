using System.Text.Json;

namespace CTeleportAssingment.Models
{
    public class AirportDetailsService : IAirportDetailsService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _serializerOptions;

        public AirportDetailsService(string baseAddress)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri(baseAddress);
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public async Task<Airport?> GetAirport(string IATACode)
        {
            var airportResponse = await _client.GetAsync(IATACode);
            if (airportResponse.IsSuccessStatusCode)
            {
                var airport = await airportResponse.Content.ReadFromJsonAsync<Airport>(_serializerOptions);
                return airport;
            }
            else
            {
                throw new Exception($"HttpResponse Error : {airportResponse.StatusCode},{airportResponse.ReasonPhrase}");
            }
        }
    }
}