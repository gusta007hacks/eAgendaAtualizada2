﻿using eAgendaAtualizada2.Dominio;
using System;
using System.Windows.Forms;

namespace eAgendaAtualizada2.WinApp
{
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;

        public CadastroCompromissos()
        {
            InitializeComponent();
        }

        public Compromisso Compromisso
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
                txtNumero.Text = compromisso.Numero.ToString();
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                txtData.Text = compromisso.DataCompromisso;
                txtHoraInicio.Text = compromisso.HoraInicio;
                txtHoraTermino.Text = compromisso.HoraTermino;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso.Assunto = txtAssunto.Text;
            compromisso.Local = txtLocal.Text;
            compromisso.DataCompromisso = txtData.Text;
            compromisso.HoraInicio = txtHoraInicio.Text;
            compromisso.HoraTermino = txtHoraTermino.Text;
        }
    }
}
