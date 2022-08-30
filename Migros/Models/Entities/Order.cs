using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int PaymentID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("ProductID")] //Foreign Key Annotation
        public Product Product { get; set; }

        [ForeignKey("PaymentID")]
       public Payment Payment { get; set; }
 
    }
}
