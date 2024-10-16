using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TicketsManagement.Models
{
    public enum TicketStatus
    {
        Open,
        Closed
    }

    
    public class Ticket
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TicketId { get; set; }
        [Required(ErrorMessage = "description is required.")]
        public string ?Description { get; set; }

        [Required(ErrorMessage = "status is required.")]
        public TicketStatus Status { get; set; } 

        [Required]
        public DateTime Date { get; set; } = DateTime.UtcNow; 
    }
}
