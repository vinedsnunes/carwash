using System.ComponentModel.DataAnnotations;

namespace CarWash.Application.Data.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string VehicleType { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public string WashType { get; set; }
    }
}
