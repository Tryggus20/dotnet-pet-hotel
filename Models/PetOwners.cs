using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace pet_hotel.Models;

public class PetOwner
{
  public int Id { get; set; }
  [Required]
  public string Name { get; set; }

public string Email { get; set; }
}