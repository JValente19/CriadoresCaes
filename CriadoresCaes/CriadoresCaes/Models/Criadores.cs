﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// Descrição de cada Criador
    /// </summary>
    public class Criadores{

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código postal do Criador
        /// </summary>
        public int CodigoPostal { get; set; }

        /// <summary>
        /// Telemovel do Criador
        /// </summary>
        public int Telemovel { get; set; }

        /// <summary>
        /// Email do Criador
        /// </summary>
        public string Email { get; set; }
    }
}