﻿using System;
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
    public partial class Pagina4 : Form
    {
        public Pagina4()
        {
            InitializeComponent();
        }

        private void BotaoAtualizar_Click(object sender, EventArgs e)
        {
            Projeto P = new Projeto();
            P.Id = int.Parse(inputID.Text);
            P.Gerente = inputGerente.Text;
            P.Status = inputStatus.Text;
            P.DataFinal = inputDataFinal.Value;

            ProjetosRepository.Update(P);

        }

    }
}
