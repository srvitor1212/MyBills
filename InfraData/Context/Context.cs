using Microsoft.EntityFrameworkCore;

namespace InfraData.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }


    }
}
