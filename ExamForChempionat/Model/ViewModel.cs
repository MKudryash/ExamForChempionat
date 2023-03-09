using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ExamForChempionat.Model
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public async Task<List<Book>> GetApi()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(@"https://iis.ngknn.ru/NGKNN/МамшеваЮС/Экзамен/api/Books");
            var json = response.Content.ReadAsStringAsync().Result;
            allBooks = JsonConvert.DeserializeObject<List<Book>>(json);

            PropertyChanged(this, new PropertyChangedEventArgs("GetBooks"));
            return allBooks;
        }
        List<Book> allBooks { get; set; } = new List<Book>();

        public List<Book> GetBooks  
        {
            get
            {
                    return allBooks;
            }
        }

    }
}
