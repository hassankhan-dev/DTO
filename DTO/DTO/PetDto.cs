using System.ComponentModel.DataAnnotations;

namespace DTO.DTO
{
    public class PetDto
    {
        [Key]
        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PDescription { get; set; }     
        public int? BreedId { get; set; }
        public int? CategoryId { get; set; }   
        public int? LocationId { get; set; }
    }
}
