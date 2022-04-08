using Core.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Core.Entities
{
    public class User : IdentityUser, IBaseEntity
    {
        public List<Topic> Topic { get; set; } = new List<Topic>();
    }
}
