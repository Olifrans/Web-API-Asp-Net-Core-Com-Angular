using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_Asp_Net_Core__Com_Angular.Models
{
    public class Banco
    {
        [Key]
        public int BancoId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        //[Required(ErrorMessage = "É obrigatório digitar o número da conta!")]
        public string BancoNome { get; set; }
    }
}
