using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelBooking.Core.Data
{
    public class HotelAddress
    {
        [Required]
        public int HotelAddressId { get; set; } // PK

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string HotelAddressCity { get; set; }

        [ForeignKey("HotelId")]
        public int HotelId { get; set; }//Foreign Key
        public Hotel Hotel { get; set; }
    }
}
