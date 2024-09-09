using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities;
[Table("Users")]
public class AppUser  
{
    public int Id { get; set; }

    public required string UserName { get; set; } 
}
