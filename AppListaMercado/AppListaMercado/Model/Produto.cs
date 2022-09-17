using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppListaMercado.Model
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Qtd { get; set; }
        public double PrecoPrevisto { get; set; }
        public double PrecoPago { get; set; }
    }
}
