using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.ComponentModel.DataAnnotations;

namespace Object_Validator
{
    public class Cat
    {
        [Required]
        public int id { get; set; }
        [Required(ErrorMessage ="This is required")]
        [StringLength(20 ,ErrorMessage ="Maximum length of this is 20")]
        public string name { get; set; }
        [Required(ErrorMessage = "This is required")]
        [Range(0,10,ErrorMessage ="Please age between 0 to 10")]
        public int age { get; set; }


    }
}
