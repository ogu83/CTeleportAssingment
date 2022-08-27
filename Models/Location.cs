using System.Text.Json.Serialization;

namespace CTeleportAssingment.Models
{
    public class Location
    {
        [JsonPropertyName("lon")]
        public double Longitude { get; set; }
        
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
    }
}