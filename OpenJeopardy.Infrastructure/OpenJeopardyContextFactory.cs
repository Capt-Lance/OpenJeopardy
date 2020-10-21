using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenJeopardy.Infrastructure
{
    public class OpenJeopardyContextFactory : IDesignTimeDbContextFactory<OpenJeopardyContext>
    {
        public OpenJeopardyContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OpenJeopardyContext>();
            optionsBuilder.UseSqlServer(@"Data Source=LOCALHOST;Initial Catalog=OpenJeopardy;Integrated Security=True");
            return new OpenJeopardyContext(optionsBuilder.Options);
        }
    }
}
