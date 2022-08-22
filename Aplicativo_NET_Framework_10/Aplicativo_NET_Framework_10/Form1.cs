using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_NET_Framework_10
{

    public partial class frm_mercadinho : Form
    {

        int id = 1;

        double total = 0;

        public frm_mercadinho()
        {

            InitializeComponent();

            txt_id_venda.Text = id.ToString();

            nup_qnt_item_selecionado.Enabled = false;

            btn_remover.Enabled = false;

            btn_nova_venda.Enabled = false;

            btn_alterar.Enabled = false;

        }

        // Esse método é executado quando a NumericUpDown - Quantidade estiver marcada e uma tecla for pressionada:

        private void nup_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            /* Nessa estrutura de decisão, estamos dizendo que, se o usuário apertar uma tecla de pontuação, 
             * ou uma tecla de símbolo, o sistema não irá aceitar e, portanto, não vai digitar na TextBox. Os outros 
             * tipos de tecla, o NumericIpDown já não aceita por padrão. */

            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        // Esse método é executado quando a NumericUpDown - Quantidade - Item Selecionado estiver marcada e uma tecla for pressionada:

        private void nup_qnt_item_selecionado_KeyPress(object sender, KeyPressEventArgs e)
        {

            /* Nessa estrutura de decisão, estamos dizendo que, se o usuário apertar uma tecla de pontuação, 
             * ou uma tecla de símbolo, o sistema não irá aceitar e, portanto, não vai digitar na TextBox. Os outros 
             * tipos de tecla, o NumericIpDown já não aceita por padrão. */

            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        // Esse método é executado quando a TextBox - Valor Unitário estiver marcada e uma tecla for pressionada:

        private void txt_valor_unitario_KeyPress(object sender, KeyPressEventArgs e)
        {

            /* Nessa estrutura de decisão, estamos dizendo que, se o usuário apertar uma tecla de controle, 
             * uma tecla numérica ou a tecla vírgula, o sistema irá aceitar, mas, se ele digitar qualquer outra tecla, 
             * o sistema não irá aceitar e, portanto, não vai digitar na TextBox. */

            if (e.KeyChar.Equals(char.Parse(",")) || char.IsControl(e.KeyChar) || char.IsNumber(e.KeyChar))
            {

                e.Handled = false;

            }

            else 
            {

                e.Handled = true;

            }

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if(txt_descricao.Text.Equals("") || txt_valor_unitario.Text.Equals(""))
            {

                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                double valor_unitario = double.Parse(txt_valor_unitario.Text);

                total += valor_unitario * int.Parse(nup_quantidade.Value.ToString());

                lbl_total_resultado.Text = total.ToString("F2");

                dgv_carrinho_de_compras.Rows.Add(id.ToString(""), txt_descricao.Text, nup_quantidade.Value.ToString(), valor_unitario.ToString("F2"));

                id++;

                txt_id_venda.Text = id.ToString();

                txt_descricao.Clear();

                nup_quantidade.Value = nup_quantidade.Minimum;

                txt_valor_unitario.Clear();

                lbl_itens_sistema_resultado.Text = dgv_carrinho_de_compras.RowCount.ToString();

                grp_informacoes_venda.Enabled = false;

                btn_inserir.Enabled = false;

                btn_nova_venda.Enabled = true;

                MessageBox.Show("Venda efetuada com sucesso.\n\nClique no botão Nova Venda para efetuar outra venda.", "Aviso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

            if(dgv_carrinho_de_compras.RowCount > 0)
            {

                btn_remover.Enabled = false;

                nup_qnt_item_selecionado.Value = nup_qnt_item_selecionado.Minimum;

                nup_qnt_item_selecionado.Enabled = false;

                btn_alterar.Enabled = false;

                double valor_exluido = int.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString()) * 
                                       double.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_valor_unitario"].Value.ToString());

                total -= valor_exluido;

                lbl_total_resultado.Text = total.ToString("F2");

                dgv_carrinho_de_compras.Rows.RemoveAt(dgv_carrinho_de_compras.CurrentCell.RowIndex);

                lbl_itens_sistema_resultado.Text = dgv_carrinho_de_compras.RowCount.ToString();

                MessageBox.Show("Venda excluída com sucesso.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if(dgv_carrinho_de_compras.RowCount > 0)
            {

                total = double.Parse(lbl_total_resultado.Text) - (int.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString()) * 
                                                                  double.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_valor_unitario"].Value.ToString()));

                dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value = nup_qnt_item_selecionado.Value.ToString();

                total += int.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString()) *
                    double.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_valor_unitario"].Value.ToString());

                lbl_total_resultado.Text = total.ToString("F2");

                nup_qnt_item_selecionado.Value = nup_qnt_item_selecionado.Minimum;

                nup_qnt_item_selecionado.Enabled = false;

                btn_alterar.Enabled = false;

                btn_remover.Enabled = false;

                MessageBox.Show("Venda alterada com sucesso.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_cancelar_venda_Click(object sender, EventArgs e)
        {

            if (txt_descricao.Text.Equals("") && txt_valor_unitario.Text.Equals(""))
            {

                MessageBox.Show("Os campos já estão em branco.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                id++;

                txt_id_venda.Text = id.ToString();

                txt_descricao.Clear();

                nup_quantidade.Value = nup_quantidade.Minimum;

                txt_valor_unitario.Clear();

                btn_inserir.Enabled = false;

                btn_nova_venda.Enabled = true;

                grp_informacoes_venda.Enabled = false;

                MessageBox.Show("Venda cancelada com sucesso.\n\nClique no botão Nova Venda para efetuar outra venda.", "Aviso!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_nova_venda_Click(object sender, EventArgs e)
        {

            grp_informacoes_venda.Enabled = true;

            btn_inserir.Enabled = true;

            btn_nova_venda.Enabled = false;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

            id = 1;

            total = 0;

            Application.Exit();

        }

        private void dgv_carrinho_de_compras_DoubleClick(object sender, EventArgs e)
        {

            if(dgv_carrinho_de_compras.RowCount > 0)
            {

                btn_remover.Enabled = true;

                btn_alterar.Enabled = true;

                nup_qnt_item_selecionado.Enabled = true;

                nup_qnt_item_selecionado.Value = decimal.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString());

            }

        }

    }

}
