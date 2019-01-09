using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppAula02CRUD.Models
{
    public class EstudanteContext : DbContext
    {
        public EstudanteContext (DbContextOptions<EstudanteContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAula02CRUD.Models.Estudante> Estudante { get; set; }
    }
}
