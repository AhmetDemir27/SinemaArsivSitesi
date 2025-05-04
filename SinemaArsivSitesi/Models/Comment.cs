using SinemaArsivSitesi.Data;
using SinemaArsivSitesi.Models; // Comment sınıfını içeren namespace
using Microsoft.AspNetCore.Identity; // IdentityUser için gerekli namespace
using Microsoft.AspNetCore.Mvc; // Controller için gerekli namespace
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SinemaArsivSitesi.Models
{
    public class Comment : BaseEntity
    {

        public string UserId { get; set; }
        public IdentityUser User { get; set; } = null!;

        public string Text { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
