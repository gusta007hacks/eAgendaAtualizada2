﻿using System;
using System.Windows.Forms;

namespace eAgendaAtualizada2.WinApp
{
    public partial class ListagemMenuPrincipal : Form
    {
        public ListagemMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas tela = new ListagemTarefas();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //CarregarTarefas();
            }
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos tela = new ListagemContatos();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //tela.CarregarContatos();
            }
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos tela = new ListagemCompromissos();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                //tela.CarregarContatos();
            }
        }
    }
}
