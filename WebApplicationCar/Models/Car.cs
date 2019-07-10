using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        [DataType(DataType.Date)]
        public  DateTime Date { get; set; }
        public int Price { get; set; }

    }
}
