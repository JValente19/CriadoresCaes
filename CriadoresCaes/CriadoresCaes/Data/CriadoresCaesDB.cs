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

        // Install-Package Microsoft.EntityFrameworkCore -version 5.0.4

        // Construtor da classe CriadoresCaesDB
        // Indicar onde está a DB à qual estas classes (tabelas) serão associadas
        // ver o conteúdo do ficheiro 'startup.cs'
        public CriadoresCaesDB(DbContextOptions<CriadoresCaesDB> options):base(options){ }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // insert DB seed

            modelBuilder.Entity<Racas>().HasData(
               new Racas { Id = 1, Designacao = "Retriever do Labrador" },
               new Racas { Id = 2, Designacao = "Serra da Estrela" },
               new Racas { Id = 3, Designacao = "Pastor Alemão" },
               new Racas { Id = 4, Designacao = "Dogue Alemão" },
               new Racas { Id = 5, Designacao = "S. Bernardo" },
               new Racas { Id = 6, Designacao = "Rafeiro do Alentejo" },
               new Racas { Id = 7, Designacao = "Golden Retriever" },
               new Racas { Id = 8, Designacao = "Border Collie" }
            );

            modelBuilder.Entity<Criadores>().HasData(
               new Criadores { Id = 1, Nome = "Marisa Vieira", NomeComercial = "da Quinta do Conde", Morada = "Largo do Pelourinho", CodigoPostal = "2305 - 515 PAIALVO", Email = "Marisa.Freitas@iol.pt", Telemovel = "967197885" },
               new Criadores { Id = 2, Nome = "Fátima Ribeiro", NomeComercial = "da Quinta do Lordy", Morada = "Praça Infante Dom Henrique", CodigoPostal = "2300 - 551 TOMAR", Email = "Fátima.Machado@gmail.com", Telemovel = "963737476" },
               new Criadores { Id = 4, Nome = "Paula Silva", NomeComercial = "do Canto do Pimenta", Morada = "Bairro Pimenta", CodigoPostal = "2300 - 324 TOMAR", Email = "Paula.Lopes@iol.pt", Telemovel = "967517256" },
               new Criadores { Id = 5, Nome = "Mariline Marques", NomeComercial = "da Casa do Sobreiral", Morada = "Zona Industrial", CodigoPostal = "2305 - 127 ASSEICEIRA TMR", Email = "Mariline.Martins@sapo.pt", Telemovel = "967212144" },
               new Criadores { Id = 6, Nome = "Marcos Rocha", NomeComercial = "da Casa do Sol", Morada = "Rua de Bacelos", CodigoPostal = "2475 - 013 BENEDITA", Email = "Marcos.Rocha@sapo.pt", Telemovel = "962125638" },
               new Criadores { Id = 7, Nome = "Alexandre Vieira", NomeComercial = "do Quintal de Cima", Morada = "Rua João Pedro Costa", CodigoPostal = "7630 - 782 ZAMBUJEIRA DO MAR", Email = "Alexandre.Dias@hotmail.com", Telemovel = "961493756" },
               new Criadores { Id = 8, Nome = "Paula Soares", NomeComercial = "da Tapada de Cima", Morada = "Praça Infante Dom Henrique", CodigoPostal = "2300 - 551 TOMAR", Email = "Paula.Vieira@clix.pt", Telemovel = "961937768" },
               new Criadores { Id = 9, Nome = "Mariline Santos", NomeComercial = "da Quinta do Bacelo", Morada = "Rua Corredora do Mestre (Palhavã de Cima)", CodigoPostal = "2300 - 390 TOMAR", Email = "Mariline.Ribeiro@iol.pt", Telemovel = "964106478" },
               new Criadores { Id = 10, Nome = "Roberto Pinto", NomeComercial = "da Flecha do Indio", Morada = "Largo do Flecheiro", CodigoPostal = "2300 - 635 TOMAR", Email = "Roberto.Vieira@sapo.pt", Telemovel = "964685937" }
            );

            modelBuilder.Entity<Caes>().HasData(
               new Caes { Id = 1, Nome = "Aguia da Quinta do Conde", Sexo = "F", Nascimento = new DateTime(2019, 4, 16), LOP = "LOP446793", RacaFK = 1 },
               new Caes { Id = 2, Nome = "Aileen da Quinta do Lordy", Sexo = "F", Nascimento = new DateTime(2019, 10, 10), LOP = "LOP446795", RacaFK = 1 },
               new Caes { Id = 3, Nome = "Aladim do Canto do Bairro Pimenta", Sexo = "F", Nascimento = new DateTime(2011, 3, 22), LOP = "LOP446801", RacaFK = 5 },
               new Caes { Id = 4, Nome = "Albert do Canto do Bairro Pimenta", Sexo = "F", Nascimento = new DateTime(2008, 6, 8), LOP = "LOP446804", RacaFK = 5 },
               new Caes { Id = 5, Nome = "Alabaster da Casa do Sobreiral", Sexo = "F", Nascimento = new DateTime(2012, 8, 21), LOP = "LOP446807", RacaFK = 2 },
               new Caes { Id = 6, Nome = "Gannett do Quintal de Cima", Sexo = "F", Nascimento = new DateTime(2010, 10, 1), LOP = "LOP446809", RacaFK = 6 },
               new Caes { Id = 7, Nome = "Gardenia da Tapada de Cima", Sexo = "F", Nascimento = new DateTime(2010, 12, 11), LOP = "LOP446811", RacaFK = 3 },
               new Caes { Id = 8, Nome = "Forte da Flecha do Indio", Sexo = "F", Nascimento = new DateTime(2013, 4, 22), LOP = "LOP446799", RacaFK = 7 },
               new Caes { Id = 9, Nome = "Garbo da Flecha do Indio", Sexo = "M", Nascimento = new DateTime(2011, 5, 10), LOP = "LOP446812", RacaFK = 7 },
               new Caes { Id = 10, Nome = "Garfunkle da Quinta do Lordy", Sexo = "F", Nascimento = new DateTime(2017, 3, 21), LOP = "LOP446814", RacaFK = 4 },
               new Caes { Id = 11, Nome = "Garnet do Quintal de Cima", Sexo = "M", Nascimento = new DateTime(2018, 1, 4), LOP = "LOP446816", RacaFK = 8 }
            );

            modelBuilder.Entity<Fotografias>().HasData(
               new Fotografias { Id = 1, Fotografia = "Retriever_do_labrador.jpg", LocalFoto = "", DataFoto = new DateTime(2019, 5, 20), CaoFK = 1 },
               new Fotografias { Id = 2, Fotografia = "Retriever_do_labrador_2.jpg", LocalFoto = "", DataFoto = new DateTime(2019, 5, 20), CaoFK = 1 },
               new Fotografias { Id = 3, Fotografia = "Retriever_do_labrador_3.jpg", LocalFoto = "", DataFoto = new DateTime(2019, 11, 18), CaoFK = 2 },
               new Fotografias { Id = 4, Fotografia = "s.bernardo.jpg", LocalFoto = "", DataFoto = new DateTime(2021, 1, 17), CaoFK = 3 },
               new Fotografias { Id = 5, Fotografia = "s.bernardo_2.jpg", LocalFoto = "casa", DataFoto = new DateTime(2019, 3, 7), CaoFK = 4 },
               new Fotografias { Id = 6, Fotografia = "serra_da_estrela.jpg", LocalFoto = "", DataFoto = new DateTime(2013, 10, 21), CaoFK = 5 },
               new Fotografias { Id = 7, Fotografia = "serra_da_estrela_2.jpg", LocalFoto = "", DataFoto = new DateTime(2012, 10, 1), CaoFK = 5 },
               new Fotografias { Id = 8, Fotografia = "Rafeiro_do_Alentejo.jpg", LocalFoto = "Quinta", DataFoto = new DateTime(2020, 10, 1), CaoFK = 6 },
               new Fotografias { Id = 9, Fotografia = "pastor_alemao_2.jpg", LocalFoto = "", DataFoto = new DateTime(2011, 1, 4), CaoFK = 7 },
               new Fotografias { Id = 10, Fotografia = "pastor_alemao.jpg", LocalFoto = "", DataFoto = new DateTime(2020, 12, 6), CaoFK = 7 },
               new Fotografias { Id = 11, Fotografia = "golden-retriever_2.jpg", LocalFoto = "", DataFoto = new DateTime(2018, 12, 23), CaoFK = 8 },
               new Fotografias { Id = 12, Fotografia = "golden-retriever.jpg", LocalFoto = "ninhada", DataFoto = new DateTime(2017, 1, 5), CaoFK = 8 },
               new Fotografias { Id = 13, Fotografia = "Golden-Retriever-1.jpg", LocalFoto = "", DataFoto = new DateTime(2020, 2, 2), CaoFK = 9 },
               new Fotografias { Id = 14, Fotografia = "Dogue_Alemao.jpg", LocalFoto = "Casa da tia Ana", DataFoto = new DateTime(2021, 4, 13), CaoFK = 10 },
               new Fotografias { Id = 15, Fotografia = "border_collie.jpg", LocalFoto = "quintal", DataFoto = new DateTime(2021, 2, 4), CaoFK = 11 }
            );

            modelBuilder.Entity<CriadoresDeCaes>().HasData(
               new CriadoresDeCaes { Id = 1, DataCompra = new DateTime(2019, 6, 15), CaoFK = 1, CriadoresFK = 1 },
               new CriadoresDeCaes { Id = 2, DataCompra = new DateTime(2019, 12, 9), CaoFK = 2, CriadoresFK = 2 },
               new CriadoresDeCaes { Id = 3, DataCompra = new DateTime(2011, 5, 21), CaoFK = 3, CriadoresFK = 4 },
               new CriadoresDeCaes { Id = 4, DataCompra = new DateTime(2008, 8, 7), CaoFK = 4, CriadoresFK = 5 },
               new CriadoresDeCaes { Id = 5, DataCompra = new DateTime(2012, 10, 20), CaoFK = 5, CriadoresFK = 6 },
               new CriadoresDeCaes { Id = 6, DataCompra = new DateTime(2010, 11, 30), CaoFK = 6, CriadoresFK = 7 },
               new CriadoresDeCaes { Id = 7, DataCompra = new DateTime(2011, 2, 9), CaoFK = 7, CriadoresFK = 8 },
               new CriadoresDeCaes { Id = 8, DataCompra = new DateTime(2013, 6, 21), CaoFK = 8, CriadoresFK = 9 },
               new CriadoresDeCaes { Id = 9, DataCompra = new DateTime(2011, 7, 9), CaoFK = 9, CriadoresFK = 10 },
               new CriadoresDeCaes { Id = 10, DataCompra = new DateTime(2017, 5, 20), CaoFK = 10, CriadoresFK = 5 },
               new CriadoresDeCaes { Id = 11, DataCompra = new DateTime(2018, 3, 5), CaoFK = 11, CriadoresFK = 8 }
            );

        }

        // Representar as Tabelas de BD
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Fotografias> Fotografias { get; set; }
        public DbSet<CriadoresDeCaes> CriadoresCaes { get; set; }


    }
}
