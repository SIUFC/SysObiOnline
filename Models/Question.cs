using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysObiOnline.Models
{
   
    public class Question
    {
        public int Id { get; set; }  
        public string Level { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string CorrectAnswer { get; set; }
    }
}
