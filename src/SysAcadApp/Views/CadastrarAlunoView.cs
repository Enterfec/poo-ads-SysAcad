using System;
using System.Linq;
using System.Windows.Forms;
using SysAcadApp.Models;
using SysAcadApp.Repositories;

namespace SysAcadApp.Views
{
    public partial class CadastrarAlunoView : Form
    {
        private readonly Aluno _aluno;
        private readonly AlunoRepository _repositorio;

        private bool _salvoComSucesso;

        public CadastrarAlunoView()
        {
            InitializeComponent();

            _repositorio = new AlunoRepository();

            _aluno = _repositorio.Novo();

            __ligador.DataSource = _aluno;
        }

        public Aluno Executar()
        {
            ShowDialog();

            if(_salvoComSucesso)
            {
                return _aluno;
            }

            return null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(_repositorio.Inserir(_aluno))
            {
                _salvoComSucesso = true;

                MessageBox.Show("Dados armazenados com sucesso.");

                Close();
            }
            else
            {
                MessageBox.Show("Ocorre uma falha ao salvar o aluno");
            }
        }
    }
}