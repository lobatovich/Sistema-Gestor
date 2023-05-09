using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODEL;
using BLL;

namespace SistemaGestor
{
    public partial class Pagina2 : Form
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {

        }

        private void BotaoConfirmar_Click(object sender, EventArgs e)
        {
            Projeto P = new Projeto();
            P.Id = ProjetosRepository.GetAll().Count + 1;
            P.Nome = inputNome.Text;
            P.Gerente = inputGerente.Text;
            P.DataDeInicio = inputDataDeInicio.Value;
            P.DataFinal = inputDataFinal.Value;
            P.Resumo = inputResumo.Text;
            P.Status = inputStatus.Text;

            ProjetosRepository.Add(P);

            //Forme Forme = new Forme();

            //Forme.Show();
            this.Close();



        }

        private void inputDataDeInicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
