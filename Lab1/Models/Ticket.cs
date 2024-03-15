using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id {  get; set; }

        public double NumberOfPeople {  get; set; }

    }
}
