namespace TarkApi.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    // hashed
    public string Password { get; set; }
    public string Role { get; set; }
    
    // Navigation Properties
    // public ICollection<Ticket> CreatedTickets { get; set; }
    // public ICollection<Ticket> AssignedTickets { get; set; }
    // public ICollection<Comment> Comments { get; set; }
    // public ICollection<Attachment> Attachments { get; set; }
    // public ICollection<UserRole> UserRoles { get; set; }
}