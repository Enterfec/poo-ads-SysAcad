using System;

namespace SysAcadApp.Models
{
	public class PessoaFisica : Pessoa
	{
		private String _cpf;

        public string Cpf
        {
            get => _cpf;
            set => _cpf = value;
        }
    }
}

