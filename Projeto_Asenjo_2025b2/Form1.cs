using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Projeto_Asenjo_2025b2.classes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Asenjo_2025b2
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label12_Click(object sender, EventArgs e)
        {
        }
        private void label13_Click(object sender, EventArgs e)
        {
        }
         private void button4_Click(object sender, EventArgs e)
         {
            if(txID.Text != string.Empty)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {    
                MessageBox.Show("Por favor, insira um ID.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa.setNome(txNome.Text);
            Pessoa.setEmail(txEmail.Text);
            Pessoa.setTelefone(txTelefone.Text);
            Pessoa.setCep(txCEP.Text);
            Pessoa.setEstado(txEstado.Text);
            Pessoa.setCidade(txCidade.Text);
            Pessoa.setBairro(txBairro.Text);
            Pessoa.setRua(txRua.Text);
            Pessoa.setNumero(txNumero.Text);
            Pessoa.setComplemento(txComplemento.Text);
            PessoaBLL.validaDados();

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            //if (Erro.getErro())
            //    MessageBox.Show(Erro.getMsg());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txNome.Text = txEmail.Text = txTelefone.Text = txCEP.Text = txEstado.Text =
            txCidade.Text = txBairro.Text = txRua.Text = txNumero.Text = txComplemento.Text = "";
            MessageBox.Show("Usuário excluido com sucesso com sucesso!");
        }

        private async void txCEP_Leave(object sender, EventArgs e)
        {
            string cep = txCEP.Text.Replace("-", "").Trim();
            if (cep.Length != 8)
            {
                MessageBox.Show("Digite um CEP válido com 8 dígitos!");
                return;
            }

            await PessoaBLL.PreencherPessoaPorCep(cep);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                return;
            }

            // Atualiza os TextBox
            txEstado.Text = Pessoa.getEstado();
            txCidade.Text = Pessoa.getCidade();
            txBairro.Text = Pessoa.getBairro();
            txRua.Text = Pessoa.getRua();
            txComplemento.Text = Pessoa.getComplemento();
        }



        private void txEstado_TextChanged(object sender, EventArgs e)
        {
        }
        

    }
}
