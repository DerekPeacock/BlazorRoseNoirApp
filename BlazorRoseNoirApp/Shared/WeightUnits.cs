using System.ComponentModel.DataAnnotations;

namespace BlazorRoseNoirApp.Shared
{
	public enum WeightUnits
	{
		[Display(Name ="Grams")]
		g,
		[Display(Name = "Kilograms")]
		kg
	}
}
