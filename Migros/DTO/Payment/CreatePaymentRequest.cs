
namespace DTO.Payment
{
    public class CreatePaymentRequest
    {
       // public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Payment_Type { get; set; }
        public string Staff_Name { get; set; }

    }
}
