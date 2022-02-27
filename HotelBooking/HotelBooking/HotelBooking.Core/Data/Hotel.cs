using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelBooking.Core.Data
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; } //PK

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string HotelName { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string HotelImage { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float Hotelprice { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float HotelDiscount { get; set; }

        [Required]
        [Column(TypeName = "varchar(Max)")]

        public string HotelDescription { get; set; }

        [Required]
        [Column(TypeName = "float")]
        public float HotelRank { get; set; }
        public virtual ICollection<HotelAddress> HotelAddresses { get; set; }




    }
}
