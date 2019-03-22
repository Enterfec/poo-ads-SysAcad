using System;

namespace SysAcadApp.Models
{
	public class Aluno : PessoaFisica
	{
		private String _matricula;

        public string Matricula
        {
            get => _matricula;
            set => _matricula = value;
        }
    }
}

