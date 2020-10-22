using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TRAVEL_TRIP.Models.classes
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }
        public string FOTOURL { get; set; }
        public string ACIKLAMA { get; set; }
    }
}