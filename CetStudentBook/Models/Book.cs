// Bu dosyayı önceden tamamladım ancak forku hatalı aldım ve kopyalamadım repo'yu
// O yüzden önceki kodumu aynen yapıştırıyorum
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Çoğunlukla Student.cs ile benzer yaptım anlatımı kolay olsun diye
namespace CetStudentBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        [Length(2,200)]
        [DisplayName("Book Title")]
        public string Name { get; set; } 
        
        [Required]
        [Length(2,200)]
        [DisplayName("Author")]
        public string Author { get; set; } 
        
        [Required]
        [DisplayName("Publish Date")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } 
        
        [Required]
        [Range(1, 10000)]
        [DisplayName("Page Count")]
        public int PageCount { get; set; }
        
        [Required]
        [DisplayName("Second Hand")]
        public bool IsSecondHand { get; set; }
        
        
    }
    
}


// Id (int, primary key) yaptım
// Name (string) // book title yaptım
// Author (string) yaptım
// PublishDate (DateTime) yaptım
// PageCount (int) yaptım 
// IsSecondHand (bool) 