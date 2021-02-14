using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Asp_Net_Core__Com_Angular.Models

{
    public class BancoConta
    {
        [Key]
        public int BancoContaId { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [Required(ErrorMessage = "É obrigatório digitar o número da conta!")]
        public string ContaNumero { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Required(ErrorMessage = "É obrigatório informa a seguradora!")]
        public string ContaSeguradora { get; set; }

        [Required(ErrorMessage = "É obrigatório informa o códigop do banco!")]
        public int BancoId { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [Required(ErrorMessage = "É obrigatório informa o código do sistema finaceiro do Brasil!")]
        public string BRFSC { get; set; }
    }
}
