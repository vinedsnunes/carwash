using System.ComponentModel.DataAnnotations;

namespace CarWash.Application.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(14)]
        public string Document { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual ICollection<Address> Address { get; set; } = new List<Address>();

        public virtual ICollection<Vehicle> CustomerVehicle { get; set; } = new List<Vehicle>();
    }
}
