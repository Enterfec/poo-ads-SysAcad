using System;

namespace SysAcadApp.Models
{
	public class Funcionario : PessoaFisica
	{
		private String _numPis;

        public string NumPis
        {
            get => _numPis;
            set => _numPis = value;
        }
    }
}

