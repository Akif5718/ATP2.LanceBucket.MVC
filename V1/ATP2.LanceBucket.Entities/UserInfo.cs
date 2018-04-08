using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP2.LanceBucket.Entities
{
    public partial class UserInfo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; } 
        [Required]
        public int UserType { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
       
        public int Gender { get; set; }      
    }
}
