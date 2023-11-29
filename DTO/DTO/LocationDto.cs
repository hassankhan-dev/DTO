using System.ComponentModel.DataAnnotations;

namespace DTO.DTO
{
    public class LocationDto
    {
        [Key]
        public int LID { get; set; }
        public string? LName { get; set; }
    }
}
