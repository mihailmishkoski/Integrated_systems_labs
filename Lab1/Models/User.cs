using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class User : IdentityUser
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname {  get; set; }
        public string Address { get; set; }

        public virtual ICollection<Ticket>? concertTickestPerUser { get; set; }
    }
}
