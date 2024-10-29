using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyWallet.Domain;

[Table("Users")]
public class User
{
    [Column]
    public string UserId { get; set; }

    [Column]
    public string FirstName { get; set; }

    [Column]
    public string LastName { get; set; }

    [Column]
    public string Email { get; set; }

    [Column]
    public string Phone { get; set; }

    [Column]
    public string Login  { get; set; }

    [Column]
    public string Password { get; set; }

    [Column]
    public bool IsAdmin { get; set; }

    [Column]
    public bool IsActive { get; set; }
}