using System;
using System.Linq;
using System.Windows.Forms;
using SysAcadApp.Views;

namespace SysAcadApp
{
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void btnGenAluno_Click(object sender, EventArgs e)
        {
            using(var view = new GestaoAlunoView())
            {
                view.ShowDialog();
            }
        }
    }
}
