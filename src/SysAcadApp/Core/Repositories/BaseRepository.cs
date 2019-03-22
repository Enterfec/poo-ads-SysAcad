using System;
using System.Data.SqlClient;

namespace SysAcadApp.Core.Repositories
{
    public abstract class Repository
    {
        private const String ParametrosContexao = @"Server=(local)\SQLEXPRESS;Database=SysAcad;Integrated Security=True";

        protected SqlConnection GetConexao()
        {
            return new SqlConnection(ParametrosContexao);
        }
    }
}