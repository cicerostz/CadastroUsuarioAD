using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UserAd
{
    public partial class Form1 : Form
    {
        DialogResult alerta;
        string pasta = @"c:\temp\";
        //string caminho = @"c:\temp\USERID.txt";
        string caminho = @"c:\temp\USERID.csv";
        //string caminho = @"\\NOTEBOOK-ASUS\Andreia\USERID.csv";

        
        
        public Form1()
        {
            InitializeComponent();
           

        }


        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSobrenome_Leave(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = txtPrimeiroNome.Text + " " + txtSobrenome.Text;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

           


            if (txtPrimeiroNome.Text == "")
            {
                alerta = MessageBox.Show("Campo primeiro nome está vazio");
            }

            else if (txtSobrenome.Text == "")
            {
                alerta = MessageBox.Show("Campo sobrenome  está vazio");
            }
            else if (txtEmail.Text == "")
            {
                alerta = MessageBox.Show("Campo e-mail está vazio");
            }
            else if (txtConta.Text == "")
            {
                alerta = MessageBox.Show("Campo conta está vazio");
            }
            else if (txtGrupo.Text == "")
            {
                alerta = MessageBox.Show("Campo grupo está vazio");
            }
            else
            {
                try
                {
                    if (!Directory.Exists(pasta))
                    {
                        Directory.CreateDirectory(pasta);
                    }


                    using (StreamWriter gravaArquivo = File.AppendText(caminho))
                    gravaArquivo.WriteLine(txtNomeCompleto.Text + ","+txtPrimeiroNome.Text + "," + txtSobrenome.Text + "," +
                       txtEmail.Text.ToLower() + "," + txtConta.Text + "," + "\"" + txtGrupo.Text + "\""
                        );
                  
                    alerta = MessageBox.Show("Gravação efeturada com sucesso!");
                    

                    lblInformacao.Text = "Arquivo salvo em: " + Path.GetFullPath(caminho);

                    txtNomeCompleto.Text = "";
                    txtPrimeiroNome.Text = "";
                    txtSobrenome.Text = "";
                    txtEmail.Text = "";
                    txtConta.Text = "";
                    txtGrupo.Text = "";


                }
                //catch (UnauthorizedAccessException erro)
                 catch (Exception erro)
                {


                       alerta = MessageBox.Show(erro.Message);
                    lblInformacao.Text = "Arquivo salvo em: " + Path.GetFullPath(caminho);
                }
            }

            try
            {

                //StreamReader lerArq = new StreamReader(caminho);
                StreamReader lerArq = new StreamReader(caminho);

                lblConteudo.Text = lerArq.ReadToEnd();
                lerArq.Close();
            }
            catch (Exception erro)
            {

                alerta = MessageBox.Show(erro.Message + "O arquivo ainda não foi criado, pois não foi inserido nenhum registro ainda, preencha os campos acima");
            }



        }

        private void btnDeletarArquivo_Click(object sender, EventArgs e)
        {


            try
            {

                StreamReader lerArq = new StreamReader(caminho);
                lerArq.Close();
           
                  
               
                    File.Delete(caminho);
                    alerta = MessageBox.Show("Arquivo apagado com sucesso!");
                
            }
            catch (Exception erro)
            {

                alerta = MessageBox.Show(erro.Message);
            }

            
           

        }

        private void llCaminhoArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ABRINDO PASTA ONDE ARQUIV ESTÁ SALVO
            bool eArqivo = System.IO.File.Exists(caminho);
            if (eArqivo) {

                string argument = @"/select, " + caminho;
                System.Diagnostics.Process.Start("explorer.exe", argument);

            }
        }
    }
}
