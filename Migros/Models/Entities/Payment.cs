
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models.Entities
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Payment_Type { get; set; }
        public string Staff_Name { get; set; }

       public ICollection<Order> Orders { get; set; }

      
    }
}
