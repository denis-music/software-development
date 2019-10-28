using DLWMS.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS.Test
{
    public class DLWMSHelper
    {

        public static DLWMSDbContext GetDLWMSDbContext()
        {
            DbContextOptionsBuilder<DLWMSDbContext> builder =
                new DbContextOptionsBuilder<DLWMSDbContext>().UseSqlServer("server =.; database = DLWMSRSI; integrated security = true");
            return new DLWMSDbContext(builder.Options);
        }


    }
}
