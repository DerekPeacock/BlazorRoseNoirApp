using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorRoseNoirApp.Shared
{
    /// <summary>
    /// A product option or variation for example
    /// different colours or sizes.  Also used to
    /// list all the ingredients or allergies in a
    /// product, see OptionType.
    /// </summary>
    public class Variation
    {
        public int Id { get; set; }
        
        // The main product
        public int ProductId { get; set; }
        // e.g. the name of a colour, or the size
        
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        // short description if needed
        
        public string? Description { get; set;} = null;

        [StringLength(100)]
        public string? ImageUrl { get; set; } = null;

		// Alternative option price if not the same as the main product
		[DataType(DataType.Currency), Range(0, 200.00)]
		[Column(TypeName = "decimal(18, 2)")]
		[DisplayFormat(DataFormatString = "{0:C0}")]
		public decimal Price { get; set; } = 0;

        // Stock Control
        [Range(0, 36)]
        public int IncomingStock { get; set; } = 0;
		[Range(0, 36)]
		public int AvailableStock { get; set; } = 1;
		[Range(0, 36)]
		public int ComittedStock { get; set; } = 0;

        // is this needed ??
        public int Size { get; set; } = 0;

        public SizeUnits SizeUnit { get; set; } = SizeUnits.cl;

        public float Weight { get; set; } = 0;

        public WeightUnits WeightUnit { get; set; } = WeightUnits.g;

        public VariationTypes VariationType {get; set;}

        public float Discount { get; set; } = 0;
    }
}
