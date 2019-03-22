using System;

namespace SysAcadApp.Models
{
	public class Fornecedor : PessoaJuridica
	{
		private String _representante;

        public string Representante
        {
            get => _representante;
            set => _representante = value;
        }
    }
}

