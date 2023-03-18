using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorRoseNoirApp.Shared
{
    /// <summary>
    /// A list of the main Product Categories
    /// used to filter the products
    /// </summary>
    public enum Categories
    {
        [Display(Name= "NONE")]
        None,

        [Display(Name = "Candles")]
         Candles,
        
        [Display(Name = "Reed Diffusers")]
        ReedDiffusers,
        
        [Display(Name = "Natural Soaps")]
        NaturalSoaps,
        
        [Display(Name = "Bath & Showers")]
        BathShowers,

        [Display(Name = "Christmas Collection")]
        ChristmasCollection
    }
}
