using System.ComponentModel.DataAnnotations;

namespace BlazorRoseNoirApp.Shared
{
	public enum SizeUnits
	{
		[Display(Name = "millilitres")]
		ml,
		[Display(Name = "centilitres")]
		cl,
		[Display(Name = "litres")]
		ltr
	}
}
