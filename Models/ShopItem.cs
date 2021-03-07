using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vives_FrietShop.Models
{
    public class ShopItem
    {
        [DisplayName("Naam:")]
        [Required(ErrorMessage = "Naam is verplicht.")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Lengte moet minimum 1 en mag maximum 20 characters zijn.")]
        public string Naam { get; set; }
        
        [DisplayName("Prijs:")]
        [RegularExpression(@"[0-9]+(\.[0-9][0-9]?)?", ErrorMessage = "De prijs moet uit cijfers bestaan met minimum 1 cijfer voor en maximum 2 cijfers na de komma (gebruik een '.' als komma).")]
        public double Prijs { get; set; }
        
        public int Id { get; set; }
    }
}