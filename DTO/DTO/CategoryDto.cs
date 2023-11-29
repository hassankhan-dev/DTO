using System.ComponentModel.DataAnnotations;

namespace DTO.DTO
{
    public class CategoryDto
    {
        [Key]
        public int CId { get; set; }
        public string? CName { get; set; }
    }
}
