using System.ComponentModel.DataAnnotations;
using TaskManagement.Models;

namespace TaskManagement.DTO
{
    public class CreateTask
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        public Priority Priority { get; set; } 
    }
}
