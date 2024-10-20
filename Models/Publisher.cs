using Tusa_Alexandra_Teodora_Lab2.Pages.Books;

namespace Tusa_Alexandra_Teodora_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
