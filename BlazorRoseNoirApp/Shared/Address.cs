using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRoseNoir.Shared
{
    public enum AddressTypes { Home, Office, PaymentCard, Other}

    /// <summary>
    /// Used to store customers delivery address associated with the payment card
    /// Author: Kate Ibom
    /// Date: 08/08/2022
    /// </summary>
    
    public class Address
    {
        public int AddressId { get; set; }
        public AddressTypes AddressType { get; set; }
        public string HouseNumber { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string District { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string County { get; set; } = string.Empty;

        public string PostCode { get; set; } = string.Empty;


        

        
    }
}
