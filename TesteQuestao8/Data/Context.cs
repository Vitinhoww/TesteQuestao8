using Microsoft.EntityFrameworkCore;
using TesteQuestao8.Models;

namespace TesteQuestao8.Data
{
    public class Context : DbContext

    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }


    }
}
