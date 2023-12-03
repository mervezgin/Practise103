using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Entities
{
    public class RoleEntity
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required, EmailAddress, MaxLength(100)] 
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
