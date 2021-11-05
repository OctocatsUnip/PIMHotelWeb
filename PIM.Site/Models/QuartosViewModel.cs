using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PIM.Site.Models
{
    public class QuartosViewModel
    {
        public string Nome_quarto { get; set; }

        public int Img_quarto { get; set; }

        public decimal Valor_quarto { get; set; }

        public int Quantia_camas { get; set; }

        public decimal Quantia_banheiros { get; set; }
    }
}
