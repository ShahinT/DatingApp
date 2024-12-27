using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    [MaxLength(256)]
    public required string UserName { get; set; }
}