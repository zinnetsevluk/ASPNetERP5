using Kimlik.Models.Entities;
using Kimlik.Models.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimlik.DALL
{
   public class MyContext:IdentityDbContext<ApplicationUser>
    {
        public MyContext():base ("name=MyCon")//connecting stringdeki ad mycon
        {
        }
        public virtual DbSet<Message> Messages { get; set; }//tabloları yazıyoruz buraya.
    }
}
