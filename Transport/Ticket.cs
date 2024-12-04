using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime StartValid { get; set; }
        public DateTime EndValid { get; set; }
        DateTimeOffset thisDate2 = new DateTimeOffset(2011, 6, 10, 15, 24, 16,
                                              TimeSpan.Zero);

        public static Ticket Ticket1 => new Ticket { Id = 1, Price = 4, StartValid = new DateTime(2023, 6, 10, 15, 24, 0), EndValid = new DateTime(2023, 6, 10, 15, 34, 0) };
        public static Ticket Ticket2 => new Ticket { Id = 2, Price = 5,  StartValid = new DateTime(2024, 5, 12, 10, 25, 0), EndValid = new DateTime(2023, 6, 10, 15, 40, 0) };
        public static Ticket Ticket3 => new Ticket { Id = 3, Price = 25, StartValid = new DateTime(2024, 12, 1, 0, 0, 0), EndValid = new DateTime(2024, 12, 8, 0, 0, 0) };
        public static Ticket Ticket4 => new Ticket { Id = 4, Price = 70, StartValid = new DateTime(2024, 12, 4, 15, 0, 0), EndValid = new DateTime(2025, 1, 4, 15, 0, 0) };
        public static Ticket Ticket5 => new Ticket { Id = 5, Price = 500, StartValid = new DateTime(2024, 1, 1, 0, 0, 0), EndValid = new DateTime(2025, 1, 1, 0, 0, 0) };
        public static Ticket Ticket6 => new Ticket { Id = 6, Price = 500, StartValid = new DateTime(2024, 1, 2, 0, 0, 0), EndValid = new DateTime(2025, 1, 2, 0, 0, 0) };

        public static IEnumerable<Ticket> DefaultTickets()
        {
            yield return Ticket1;
            yield return Ticket2;
            yield return Ticket3;
            yield return Ticket4;
            yield return Ticket5;
            yield return Ticket6;
        }
    }
}
