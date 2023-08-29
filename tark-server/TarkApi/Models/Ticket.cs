namespace TarkApi.Models;

public class Ticket
{
    public int TicketId { get; set; }
    public int ProjectId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; } = "No Status"; // serves as the category for kanban boards
    public int CreatedByUserId { get; set; }
    public int? AssignedToUserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Navigational Properties
    // public Project Project { get; set; }
    // public User CreatedByUser { get; set; }
    // public User AssignedToUser { get; set; }
    // public ICollection<Comment> Comments { get; set; }
    // public ICollection<Attachment> Attachments { get; set; }
}