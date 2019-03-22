using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SysAcadApp.Models;

namespace SysAcadApp.Views
{
    public partial class GestaoAlunoView : Form
    {
        private readonly BindingList<Aluno> _alunos;

        public GestaoAlunoView()
        {
            InitializeComponent();

            _alunos = new BindingList<Aluno>();

            __ligadorUI.DataSource = _alunos;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastrarAluno();
        }

        public void CadastrarAluno()
        {
            using(var view = new CadastrarAlunoView())
            {
                var novoAluno = view.Executar();
                if(novoAluno != null)
                {
                    _alunos.Add(novoAluno);
                }
            }
        }
    }
}