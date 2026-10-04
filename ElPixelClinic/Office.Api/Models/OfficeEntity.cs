using System.ComponentModel.DataAnnotations;

namespace Office.Api.Models;

public class OfficeEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [Required]
    public string Address { get; set; } = string.Empty;
    [Required]
    public string RegistryPhoneNumber { get; set; } = string.Empty;
    [Required]
    public bool IsActive { get; set; } = true;
}

