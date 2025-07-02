using System.ComponentModel.DataAnnotations;

namespace SysObiOnline.Models
{
    public class Question
    {
        [Required]
        public string Id { get; set; }  
        public string Level { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
    }
}
