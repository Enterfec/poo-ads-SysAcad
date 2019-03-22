using System;

namespace SysAcadApp.Models
{
	public class PessoaJuridica : Pessoa
	{
		private String _cnpj;

        public string Cnpj
        {
            get => _cnpj;
            set => _cnpj = value;
        }
    }
}

