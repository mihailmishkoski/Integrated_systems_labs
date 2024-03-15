using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class Concert
    {
        [Key]
        public Guid Id { get; set; }
        public string ConcertName {  get; set; }
        public DateTime ConcertDate {  get; set; }
        public string ConcertPlace {  get; set; }
        public double ConcertPrice {  get; set; }

        public virtual ICollection<Ticket>? concertTickets { get; set; }
    }
}
