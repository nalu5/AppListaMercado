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
        public double ValorPrevisto { get; set; }
        public double Valor { get; set; }
    }
}
