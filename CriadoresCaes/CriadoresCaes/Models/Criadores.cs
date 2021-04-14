using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models{

    /// <summary>
    /// Descrição de cada Criador
    /// </summary>
    public class Criadores{

        // inicializar a lista de Cães do Criador
        public Criadores(){
            ListaDeCaes = new HashSet<CriadoresDeCaes>();
        }

        /// <summary>
        /// Identificador do Criador
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Nome do Criador
        /// </summary>
        [Required(ErrorMessage = "O nome é de preenchimento obrigatório")]
        [StringLength (60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres")]
        [RegularExpression("([A-ZÁÂÀÃÉÈÍÓÒÔÕÚÇÑa-záàãâéèêíóòõôúçñ '-]+)+")]
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais de {1} caracteres")]
        [Display(Name = "Afixo")]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "A {0} não pode ter mais de {1} caracteres")]
        public string Morada { get; set; }

        /// <summary>
        /// Código postal do Criador
        /// </summary>
        [Required(ErrorMessage = "Deve escrever o {0}")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}( [a-zA-Z]+)+")]
        [Display(Name ="Código Postal")]
        public string CodigoPostal { get; set; }

        /// <summary>
        /// Telemovel do Criador
        /// </summary>
        [StringLength(14, MinimumLength =9, ErrorMessage ="O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, por favor, um nº de telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional.")]
        public string Telemovel { get; set; } // ou se escreve o Telemóvel, ou o Email, ou os dois...

        /// <summary>
        /// Email do Criador
        /// </summary>
        [StringLength(50, ErrorMessage ="O {0} não pode ter mais de {1} caracteres")]
        [EmailAddress(ErrorMessage ="O {0} introduzido não é válido")]
        [RegularExpression("((((aluno)|(es((tt)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt", ErrorMessage ="Só são aceites emails do IPT")]
        public string Email { get; set; } // ou se escreve o Telemóvel, ou o Email, ou os dois...

        // #######################################################


        /// <summary>
        /// lista dos Cães associados ao Criador
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaDeCaes { get; set; }
    }
}
