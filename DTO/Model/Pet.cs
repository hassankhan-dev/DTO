using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DTO.Model
{
    public class Pet
    {
        [Key]
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PDescription { get; set; }
        [JsonIgnore]
        public int? BreedId { get; set; }
        [JsonIgnore]
        public int? CategoryId { get; set; }
        [JsonIgnore]
        public int? LocationId { get; set; }

        public Category? category { get; set; }
        public Location? location { get; set; }
        public Breed? breed { get; set; }
    }
}
