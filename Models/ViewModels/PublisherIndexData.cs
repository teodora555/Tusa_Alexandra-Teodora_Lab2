using Tusa_Alexandra_Teodora_Lab2.Models;

namespace Tusa_Alexandra_Teodora_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
