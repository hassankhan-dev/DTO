using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Location
    {
        [Key]
        public int LID { get; set; }
        public string? LName { get; set; }
    }
}
