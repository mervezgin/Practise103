using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Entity
{
    public class UserEntity : IdentityUser
    {
        public string City { get; set; }

    }
}
