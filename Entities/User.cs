using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GitClash.Entities;

public class User : IdentityUser
{
    [Required]
    public int GitHubId { get; set; }
    
    [MaxLength(100)]
    public string Nickname { get; set; } = string.Empty;
    
    [MaxLength(500)]
    public string AvatarUrl { get; set; } = string.Empty;
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}