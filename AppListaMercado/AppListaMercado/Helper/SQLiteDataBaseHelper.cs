using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
using AppListaMercado.Model;
using System.Threading.Tasks;

namespace AppListaMercado.Helper
{
    public class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteDataBaseHelper(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Produto>().Wait();
        }

        public Task<int> Save(Produto t)
        {
            return _connection.InsertAsync(t);
        }

        public Task<List<Produto>> GetAllRows()
        {
            return _connection.Table<Produto>().ToListAsync();
        }

        public Task<int> Delete(int id)
        {
            return _connection.Table<Produto>().DeleteAsync(i => i.Id == id);
        }

        public Task<List<Produto>> Update(Produto t)
        {
            string sql = "UPDATE produto SET " +
                         "NomeProduto=?, Qntd=?, PrecoEstimado=?, PrecoPago=? " +
                         "WHERE Id=?";

            return _connection.QueryAsync<Produto>(sql,
                t.NomeProduto, t.Qntd, t.PrecoEstimado, t.PrecoPago, t.Id);
        }

        public Task<List<Produto>> Search(string q)
        {
            string sql = "SELECT * FROM produto WHERE Descricao LIKE '%" + q + "%'";

            return _connection.QueryAsync<Produto>(sql);
        }
    }
}
