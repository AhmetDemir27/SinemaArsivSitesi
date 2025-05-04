using SinemaArsivSitesi.Data;
using SinemaArsivSitesi.Models; // Comment sınıfını içeren namespace
using Microsoft.AspNetCore.Identity; // IdentityUser için gerekli namespace
using Microsoft.AspNetCore.Mvc; // Controller için gerekli namespace
using Microsoft.AspNetCore.Mvc.Rendering; // SelectList için gerekli namespace
namespace SinemaArsivSitesi.Models;

public class ErrorViewModel :BaseEntity
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
