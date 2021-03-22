using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// descrição de cada um dos cães
    /// </summary>
    public class Caes{

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
        /// Data de Compra
        /// </summary>
        public DateTime DataCompra { get; set; }

        /// <summary>
        /// Registo do cão no Livro de Origem PortuguêsRacas (LOP)
        /// </summary>
        public string LOP { get; set; }

    }
}
