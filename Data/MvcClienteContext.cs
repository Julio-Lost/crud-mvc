using Microsoft.EntityFrameworkCore;
using MvcCliente.Models;

namespace MvcCliente.Data
{
    public class MvcClienteContext : DbContext
    {
        public MvcClienteContext(DbContextOptions<MvcClienteContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}