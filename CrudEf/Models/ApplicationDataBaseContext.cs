using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudEf.Models
{
    public class ApplicationDataBaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=Localhost;Initial Catalog=CrudAluno; Integrated Security=True");
        }
        public DbSet<Aluno> Alunos { get; set; }
        
    }
}
