using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_first_lesson.Entities
{
    public class UserProfile
    {

        [Key]
        public int Id { get; set; }

        [Required] //обовязковий елемент
        [StringLength(maximumLength:250)]
        public string Name { get; set; }

        [Required] //обовязковий елемент
        [StringLength(maximumLength: 128)]
        public string Image { get; set; }

        [Required, StringLength(maximumLength: 50)] //обовязковий елемент
        public string Telephone  { get; set; }
    }
}
