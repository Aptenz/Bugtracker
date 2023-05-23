using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? AppUserID { get; set; }

        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public int CreatedBy { get; set; }

        [Required]
        public DateTime? CreatedDate { get; set; }
        [Required]
        public DateTime? LastModifiedDate { get; set; }
        [Required]
        public DateTime? DueDate { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; } = new HashSet<AppUser>();
    }
}
