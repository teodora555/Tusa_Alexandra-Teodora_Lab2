using System.ComponentModel.DataAnnotations;

namespace Tusa_Alexandra_Teodora_Lab2.Models
{
    public class Borrowing
    {
        public int ID { get; set; }

        public int? MemberID { get; set; }
        public Member? Member { get; set; }

        public int? BookID { get; set; }
        public Book? Book { get; set; }

        [Display(Name = "Full Name")]
        public string? BookFullName
        {
            get
            {
                return Book.Title + " - " + Book.Author.LastName + " " + Book.Author.FirstName;
            }
        }

        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}
