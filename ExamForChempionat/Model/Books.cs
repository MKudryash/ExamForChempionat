using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamForChempionat.Model
{
    public class Bookss
    {
        public List<Book> json { get; set; }

    }
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Cost { get; set; }
        public int StockAvailability { get; set; }
        public int AvailabilityInTheStore { get; set; }
        public string Description { get; set; }
        public string Rewiews { get; set; }
        public string Image { get; set; }
    }
}
