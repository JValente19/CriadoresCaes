using CriadoresCaes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Data{
    /// <summary>
    /// Representa a Base de dados a ser utilizada neste projeto
    /// </summary>
    public class CriadoresCaesDB : DbContext {

        // Construtor da classe CriadoresCaesDB
        // Indicar onde está a DB à qual estas classes (tabelas) serão associadas
        // ver o conteúdo do ficheiro 'startup.cs'
        public CriadoresCaesDB(DbContextOptions<CriadoresCaesDB> options):base(options){ 
            
        }

        // Representar as Tabelas de BD
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<CriadoresDeCaes> CriadoresCaes { get; set; }


    }
}
