using System;

namespace SysAcadApp.Models
{
	public class NumeroTelefone
	{
		private Int32 _id;
		private String _numero;
		private Byte _tipo;
		private Pessoa _pessoa;

        public int ID
        {
            get => _id;
            set => _id = value;
        }

        public string Numero
        {
            get => _numero;
            set => _numero = value;
        }

        public byte Tipo
        {
            get => _tipo;
            set => _tipo = value;
        }

        public Pessoa Pessoa1
        {
            get => _pessoa;
            set => _pessoa = value;
        }
    }

}

