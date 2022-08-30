namespace DTO.Payment
{
    public class UpdatePaymentRequest
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Payment_Type { get; set; }
        public string Staff_Name { get; set; }
    }
}
