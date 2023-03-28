using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRoseNoirApp.Shared
{
    public enum PhoneNumberTypes 
    {
        Home, Mobile, Work, Other 
    }

    /// <summary>
    /// Used to store currrent number assocated with the customer
    /// Author: Kate Ibom
    /// Date: 08/08/2020
    /// </summary>
    public class PhoneNumber
    {
        [Key]
        public int PhoneNumberId { get; set; }

        public PhoneNumberTypes NumberType { get; set; } = PhoneNumberTypes.Mobile;

        [StringLength(4), DisplayName("International Code")]
        public string InternationalCode { get; set; } = "+44";

		[StringLength(5), DisplayName("Area Code")]
		public string AreaCode { get; set; } =  string.Empty ;
		
        [StringLength(10), DisplayName("Phone Number")]
		public string Number { get; set; } = string.Empty;
    }
}
