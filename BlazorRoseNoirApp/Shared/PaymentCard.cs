namespace BlazorRoseNoir.Shared
{
    public enum PaymentBanks { Tesco, Nationwide, Barclays, HSBC, NatWest }

    public enum PaymentTypes { PayPal, GooglePay, CreditCard, DebitCard }

    public class PaymentCard
    {
        public int PaymentCardId { get; set; }

        public PaymentTypes PaymentType { get; set; } = PaymentTypes.DebitCard;

        public int CustomerId { get; set; }
         
        public PaymentBanks Bank { get; set; }
        
        public string CardNumber { get; set; } = string.Empty;

        public string NameOnCard { get; set; } = string.Empty;

        public int ExpiryYear { get; set; } = 0;
        
        public int ExpiryMonth { get; set; } = 0;

    }
}
