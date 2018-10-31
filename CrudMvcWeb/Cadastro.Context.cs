using CrudMvcWeb.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CrudMvcWeb
{
    
    public partial class BancoVendasEntities : DbContext
    {
        public BancoVendasEntities(): base("name=BancoVendasEntities")
        {
            Database.CreateIfNotExists();
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Consultor> Consultors { get; set; }
    }
}
