using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DTO.Model
{
    public class Breed
    {
        [Key]
        public int BId { get; set; }
        public string? BName { get; set; }
        public int? Category { get; set; }
        [JsonIgnore]
        public Category? category { get; set; }
    }
}
