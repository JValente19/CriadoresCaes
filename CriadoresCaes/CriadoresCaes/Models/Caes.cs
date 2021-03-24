using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// descrição de cada um dos cães
    /// </summary>
    public class Caes{

        public Caes() {
            // inicializar a lista de Fotografias de cada um dos cães
            ListasDeFotografias = new HashSet<Fotografias>();

            // inicializar a lista de Criadores do cão
            ListaCriadores = new HashSet<CriadoresDeCaes>();
        }

        /// <summary>
        /// Identificador de cada cão
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do cão
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de Nascimento
        /// </summary>
        public DateTime Nascimento { get; set; }

        /// <summary>
        /// Registo do cão no Livro de Origem PortuguêsRacas (LOP)
        /// </summary>
        public string LOP { get; set; }

        // *******************************************************************

        /// <summary>
        /// FK para a Raça do Cão
        /// </summary>
        
        [ForeignKey(nameof(Raca))] // esta 'anotação' indica o atributo 'RacaFK' está a executar o mesmo que o atributo 'Raca', 
                             // e que representa uma FK para a classe Raca
        public int RacaFK { get; set; } // atributo para ser usado no SGBD e no C#. representa a FK para a Raça do Cão
        public Racas Raca { get; set; }  // atributo para ser usado no C#. representa a FK para a Raça do Cão



        /* se estivesse-mos a criar a tabela 'Caes' em SQL
         * CREATE TABLE Caes (
         *      Id  INT PRIMARY KEY,
         *      Nome VARCHAR(30) NOT NULL,
         *      .....
         *      RacaFK INT NOT NULL,
         *      LOP VARCHAR(20)
         *      FOREIGN KEY (RacaFK) REFERENCE Racas(Id)
         *)
         */

        // ###########################################################

        // associar os cães às suas fotografias
        public ICollection<Fotografias> ListasDeFotografias { get; set; }

        // ###########################################################

        // associar os Cães aos deus Criadores

        /// <summary>
        /// Lista dos Criadores associado ao cão
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaCriadores { get; set; }

    }
}



