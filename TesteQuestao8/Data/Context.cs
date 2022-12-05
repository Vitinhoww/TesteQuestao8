using Microsoft.EntityFrameworkCore;
using TesteQuestao8.Models;

namespace TesteQuestao8.Data
{
    public class Context : DbContext

    {
        public Context(DbContextOptions options): base(options)
        {

        }

        public DbSet<Cliente> CLiente { get; set; }


    }
}
