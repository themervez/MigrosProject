using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Customer
    {
        [Key] //Primary Key Annotation
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public int AddressID { get; set; }
        public ICollection<Order> Orders { get; set; }

        [ForeignKey("AddressID")]
        public AdressDetails AdressDetails { get; set; }
    }
}
