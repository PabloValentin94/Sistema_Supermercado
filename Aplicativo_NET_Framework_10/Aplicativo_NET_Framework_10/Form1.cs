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

            btn_remover.Enabled = false;

            btn_nova_venda.Enabled = false;

            btn_alterar.Enabled = false;

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {

            if(txt_descricao.Text.Equals("") || txt_quantidade.Text.Equals("") || txt_valor_unitario.Text.Equals(""))
            {

                MessageBox.Show("Preencha todos os campos antes de prosseguir.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                double valor_unitario = double.Parse(txt_valor_unitario.Text);

                total += valor_unitario * int.Parse(txt_quantidade.Text);

                lbl_total_resultado.Text = total.ToString("F2");

                dgv_carrinho_de_compras.Rows.Add(id.ToString(""), txt_descricao.Text, txt_quantidade.Text, valor_unitario.ToString("F2"));

                id++;

                txt_id_venda.Text = id.ToString();

                txt_descricao.Clear();

                txt_quantidade.Clear();

                txt_valor_unitario.Clear();

                lbl_itens_sistema_resultado.Text = dgv_carrinho_de_compras.RowCount.ToString();

            }

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {

            if(dgv_carrinho_de_compras.RowCount > 0)
            {

                btn_remover.Enabled = false;

                txt_qnt_item_selecionado.Clear();

                txt_qnt_item_selecionado.Enabled = false;

                btn_alterar.Enabled = false;

                double valor_exluido = 
                    int.Parse(dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString()) * 
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

                dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value = txt_qnt_item_selecionado.Text;

                MessageBox.Show("Venda alterada com sucesso.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_qnt_item_selecionado.Clear();

                txt_qnt_item_selecionado.Enabled = false;

                btn_alterar.Enabled = false;

                btn_remover.Enabled = false;

            }

        }

        private void btn_cancelar_venda_Click(object sender, EventArgs e)
        {

            if (txt_descricao.Text.Equals("") && txt_quantidade.Text.Equals("") && txt_valor_unitario.Text.Equals(""))
            {

                MessageBox.Show("Os campos já estão em branco.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                id++;

                txt_id_venda.Text = id.ToString();

                txt_descricao.Clear();

                txt_quantidade.Clear();

                txt_valor_unitario.Clear();

                btn_inserir.Enabled = false;

                btn_nova_venda.Enabled = true;

                grp_informacoes_venda.Enabled = false;

                MessageBox.Show("Venda cancelada com sucesso.\nClique no botão Nova Venda para efetuar outra venda.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_nova_venda_Click(object sender, EventArgs e)
        {

            if(grp_informacoes_venda.Enabled.Equals(true))
            {

                MessageBox.Show("Você já está no meio de uma venda.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                grp_informacoes_venda.Enabled = true;

                btn_inserir.Enabled = true;

                btn_nova_venda.Enabled = false;

            }

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

                txt_qnt_item_selecionado.Enabled = true;

                txt_qnt_item_selecionado.Text = dgv_carrinho_de_compras.CurrentRow.Cells["coluna_quantidade"].Value.ToString();

            }

        }

    }

}
