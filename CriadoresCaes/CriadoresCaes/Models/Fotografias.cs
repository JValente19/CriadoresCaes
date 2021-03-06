using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// Fotografia de cada animal/cão
    /// </summary>
    public class Fotografias{

        /// <summary>
        /// Identificador da fotografia
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Fotografia
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Data da Fotografia
        /// </summary>
        [Display(Name = "Data da fotografia")]
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local da Fotografia
        /// </summary>
        public string LocalFoto { get; set; }

        // ***************************************************************

        // criação da FK que referencia o Cão a quem a Foto pertence
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }
    }
}
