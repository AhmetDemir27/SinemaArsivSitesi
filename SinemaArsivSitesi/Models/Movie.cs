using SinemaArsivSitesi.Data;
using SinemaArsivSitesi.Models; // Comment sınıfını içeren namespace
using Microsoft.AspNetCore.Identity; // IdentityUser için gerekli namespace
using Microsoft.AspNetCore.Mvc; // Controller için gerekli namespace
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SinemaArsivSitesi.Models
{
    public class Movie  :BaseEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; }  // Description özelliği
        public string PosterUrl { get; set; }   // PosterUrl özelliği
        public int CategoryId { get; set; }
        public Category Category { get; set; }  // Category ile ilişki
    }
}
