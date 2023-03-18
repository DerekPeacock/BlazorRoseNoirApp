using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorRoseNoirApp.Shared
{
    //https://www.larosenoir.co.uk/

    public class Product
    {
        public int ProductId { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        // Formatted text
        public string? Description { get; set; } = null;

        [StringLength(60), DisplayName("Image")]
        public string? MainImageUrl { get; set; } = null;

        public Categories Category { get; set; }

        [DataType(DataType.Currency), Range(0, 200.00)]
        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; } = 0;

        public float Discount { get; set; } = 0;

        public string CountryOfOrigin { get; set; } = "uk";

        [DisplayName("Ingredients")]
        public string? IngredientList { get; set; } = null;

        [DisplayName("Allergens")]
        public string? AllergenList { get; set; } = null;

		public virtual ICollection<Variation> Variations { get; set; } = new List<Variation>();   
    }

}
