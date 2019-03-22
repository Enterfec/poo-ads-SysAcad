using System;

namespace SysAcadApp.Models
{
	public class Endereco
	{
		private Int32 _id;
		private String _logradouro;
		private String _numero;
		private String _bairro;
		private string _municipio;
		private char[] _uf;
		private Pessoa _pessoa;

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Logradouro
        {
            get => _logradouro;
            set => _logradouro = value;
        }

        public string Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public string Bairro
        {
            get => _bairro;
            set => _bairro = value;
        }

        public string Municipio
        {
            get => _municipio;
            set => _municipio = value;
        }

        public char[] Uf
        {
            get => _uf;
            set => _uf = value;
        }

        public Pessoa Pessoa
        {
            get => _pessoa;
            set => _pessoa = value;
        }
    }

}

