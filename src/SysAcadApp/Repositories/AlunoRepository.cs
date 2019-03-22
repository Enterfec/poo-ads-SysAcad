using System;
using System.Data.SqlClient;
using SysAcadApp.Core.Repositories;
using SysAcadApp.Models;

namespace SysAcadApp.Repositories
{
    public class AlunoRepository : Repository
    {
        public bool Inserir(Aluno aluno)
        {
            using(var conexao = GetConexao())
            {
                var comando = conexao.CreateCommand();
                comando.CommandText = @"
                    DECLARE
	                    @id	INT;

                    INSERT
	                    INTO dbo.Pessoa
		                    (Nome)
	                    VALUES
		                    (@Nome);

                    SET @id = SCOPE_IDENTITY();

                    INSERT
	                    INTO dbo.PessoalFisica
		                    (ID, Cpf)
	                    VALUES
		                    (@id, @Cpf);

                    INSERT
	                    INTO dbo.Aluno
		                    (ID, Matricula)
	                    VALUES
		                    (@id, @Matricula);

                    SELECT
		                    @id;";

                comando.Parameters.AddRange(
                    new []
                        {
                            new SqlParameter("@Nome", aluno.Nome), 
                            new SqlParameter("@Cpf", aluno.Cpf), 
                            new SqlParameter("@Matricula", aluno.Matricula) 
                        }
                    );

                conexao.Open();

                aluno.ID = (int)comando.ExecuteScalar();
                
                return true;
            }

        }

        public Aluno Novo()
        {
            var ui = Guid.NewGuid();

            return new Aluno
                {
                    Matricula = "2019"+ ui.ToString("N").Substring(0, 11)
                };
        }
    }
}