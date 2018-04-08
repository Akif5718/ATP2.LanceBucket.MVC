using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATP2.LanceBucket.Entities;

namespace ATP2.LanceBucket.Data
{
    public class LBDbContext:DbContext
    {
        public LBDbContext() : base("LBDBConn")
        {

        }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
