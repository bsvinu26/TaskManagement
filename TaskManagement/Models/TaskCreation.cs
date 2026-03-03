using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
    public class TaskCreation
    {

        public int Id { get; set; }

      
        public string Title { get; set; }
      
        public string Description { get; set; }

        public TaskStatus Status { get; set; } 

        public Priority Priority { get; set; } 

        public DateTime CreatedAt { get; set; }

    }


      

    
}
