using System.ComponentModel.DataAnnotations;

namespace CarWash.Application.Data.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [MaxLength(10)]
        public string ZipCode { get; set; }

        [MaxLength(200)]
        public string Street { get; set; }

        [MaxLength(25)]
        public string Number { get; set; }

        [MaxLength(100)]
        public string Complement { get; set; }

        [MaxLength(60)]
        public string District { get; set; }

        [MaxLength(60)]
        public string City { get; set; }

        [MaxLength(60)]
        public string State { get; set; }

        public virtual Customer Costumer { get; set; }
    }
}
