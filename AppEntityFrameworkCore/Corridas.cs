using System;
using System.Collections.Generic;
using System.Text;

namespace AppEntityFrameworkCore
{
    class Corridas
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        public decimal Preco { get; set; }
        public string Horario { get; set; }
        public string Pagamento { get; set; }
        public string Fpagamento { get; set; }
        //public int ID_Usuario { get; set; }
        //public int ID_Motorista { get; set; }
    }
}