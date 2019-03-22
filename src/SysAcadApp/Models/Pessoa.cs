using System;
using System.Collections.Generic;

namespace SysAcadApp.Models
{
	public class Pessoa
	{
		private Int32 _id;
		private String _nome;
		private ICollection<NumeroTelefone> _numeroTelefone;
		private ICollection<Endereco> _endereco;

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }

        public ICollection<NumeroTelefone> Telefone
        {
            get => _numeroTelefone;
            set => _numeroTelefone = value;
        }

        public ICollection<Endereco> Endereco
        {
            get => _endereco;
            set => _endereco = value;
        }
    }
}

