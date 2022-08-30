using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class AdressDetails
    {
        [Key]
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public string Address_Line { get; set; }
        public string City { get; set; }

        //Adding Postal_Code Field after firstMigration
        public string Postal_Code { get; set; }
        public string Country { get; set; }
        public Customer Customer { get; set; }

    }
}
