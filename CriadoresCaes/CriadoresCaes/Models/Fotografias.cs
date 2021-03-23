using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// Fotografia de cada animal/cão
    /// </summary>
    public class Fotografias{

        /// <summary>
        /// Fotografia
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Data da Fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local da Fotografia
        /// </summary>
        public string LocalFoto { get; set; }
    }
}
