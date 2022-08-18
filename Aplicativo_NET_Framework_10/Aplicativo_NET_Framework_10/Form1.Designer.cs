namespace Aplicativo_NET_Framework_10
{
    partial class frm_mercadinho
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_id_venda = new System.Windows.Forms.Label();
            this.lbl_valor_unitario = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_id_venda = new System.Windows.Forms.TextBox();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txt_valor_unitario = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.dgv_carrinho_de_compras = new System.Windows.Forms.DataGridView();
            this.coluna_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluna_valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_informacoes_venda = new System.Windows.Forms.GroupBox();
            this.lbl_qnt_item_selecionado = new System.Windows.Forms.Label();
            this.txt_qnt_item_selecionado = new System.Windows.Forms.TextBox();
            this.grp_sistema = new System.Windows.Forms.GroupBox();
            this.lbl_itens_sistema_resultado = new System.Windows.Forms.Label();
            this.lbl_total_resultado = new System.Windows.Forms.Label();
            this.lbl_itens_sistema = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_nova_venda = new System.Windows.Forms.Button();
            this.btn_cancelar_venda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho_de_compras)).BeginInit();
            this.grp_informacoes_venda.SuspendLayout();
            this.grp_sistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_id_venda
            // 
            this.lbl_id_venda.AutoSize = true;
            this.lbl_id_venda.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_venda.Location = new System.Drawing.Point(25, 46);
            this.lbl_id_venda.Name = "lbl_id_venda";
            this.lbl_id_venda.Size = new System.Drawing.Size(57, 18);
            this.lbl_id_venda.TabIndex = 0;
            this.lbl_id_venda.Text = "Venda:";
            // 
            // lbl_valor_unitario
            // 
            this.lbl_valor_unitario.AutoSize = true;
            this.lbl_valor_unitario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_valor_unitario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor_unitario.Location = new System.Drawing.Point(409, 46);
            this.lbl_valor_unitario.Name = "lbl_valor_unitario";
            this.lbl_valor_unitario.Size = new System.Drawing.Size(106, 18);
            this.lbl_valor_unitario.TabIndex = 1;
            this.lbl_valor_unitario.Text = "Valor Unitário:";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricao.Location = new System.Drawing.Point(25, 100);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(84, 18);
            this.lbl_descricao.TabIndex = 2;
            this.lbl_descricao.Text = "Descrição:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.BackColor = System.Drawing.Color.Transparent;
            this.lbl_quantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantidade.Location = new System.Drawing.Point(199, 46);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(93, 18);
            this.lbl_quantidade.TabIndex = 3;
            this.lbl_quantidade.Text = "Quantidade:";
            // 
            // txt_id_venda
            // 
            this.txt_id_venda.Enabled = false;
            this.txt_id_venda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_venda.Location = new System.Drawing.Point(88, 43);
            this.txt_id_venda.Name = "txt_id_venda";
            this.txt_id_venda.Size = new System.Drawing.Size(105, 26);
            this.txt_id_venda.TabIndex = 4;
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade.Location = new System.Drawing.Point(298, 43);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(105, 26);
            this.txt_quantidade.TabIndex = 5;
            // 
            // txt_valor_unitario
            // 
            this.txt_valor_unitario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor_unitario.Location = new System.Drawing.Point(521, 43);
            this.txt_valor_unitario.Name = "txt_valor_unitario";
            this.txt_valor_unitario.Size = new System.Drawing.Size(105, 26);
            this.txt_valor_unitario.TabIndex = 6;
            // 
            // txt_descricao
            // 
            this.txt_descricao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(115, 97);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(511, 26);
            this.txt_descricao.TabIndex = 7;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_inserir.BackColor = System.Drawing.Color.Green;
            this.btn_inserir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(188, 178);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(111, 36);
            this.btn_inserir.TabIndex = 8;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_remover.BackColor = System.Drawing.Color.Red;
            this.btn_remover.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remover.ForeColor = System.Drawing.Color.White;
            this.btn_remover.Location = new System.Drawing.Point(363, 178);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(111, 36);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = false;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // dgv_carrinho_de_compras
            // 
            this.dgv_carrinho_de_compras.AllowUserToAddRows = false;
            this.dgv_carrinho_de_compras.AllowUserToDeleteRows = false;
            this.dgv_carrinho_de_compras.AllowUserToOrderColumns = true;
            this.dgv_carrinho_de_compras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_carrinho_de_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_carrinho_de_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrinho_de_compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coluna_id,
            this.coluna_descricao,
            this.coluna_quantidade,
            this.coluna_valor_unitario});
            this.dgv_carrinho_de_compras.Location = new System.Drawing.Point(15, 230);
            this.dgv_carrinho_de_compras.Name = "dgv_carrinho_de_compras";
            this.dgv_carrinho_de_compras.ReadOnly = true;
            this.dgv_carrinho_de_compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_carrinho_de_compras.Size = new System.Drawing.Size(653, 342);
            this.dgv_carrinho_de_compras.TabIndex = 10;
            this.dgv_carrinho_de_compras.DoubleClick += new System.EventHandler(this.dgv_carrinho_de_compras_DoubleClick);
            // 
            // coluna_id
            // 
            this.coluna_id.HeaderText = "ID";
            this.coluna_id.Name = "coluna_id";
            this.coluna_id.ReadOnly = true;
            this.coluna_id.Width = 48;
            // 
            // coluna_descricao
            // 
            this.coluna_descricao.HeaderText = "Descrição";
            this.coluna_descricao.Name = "coluna_descricao";
            this.coluna_descricao.ReadOnly = true;
            this.coluna_descricao.Width = 105;
            // 
            // coluna_quantidade
            // 
            this.coluna_quantidade.HeaderText = "Quantidade";
            this.coluna_quantidade.Name = "coluna_quantidade";
            this.coluna_quantidade.ReadOnly = true;
            this.coluna_quantidade.Width = 114;
            // 
            // coluna_valor_unitario
            // 
            this.coluna_valor_unitario.HeaderText = "Valor Unitário";
            this.coluna_valor_unitario.Name = "coluna_valor_unitario";
            this.coluna_valor_unitario.ReadOnly = true;
            this.coluna_valor_unitario.Width = 127;
            // 
            // grp_informacoes_venda
            // 
            this.grp_informacoes_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_informacoes_venda.BackColor = System.Drawing.Color.Transparent;
            this.grp_informacoes_venda.Controls.Add(this.txt_descricao);
            this.grp_informacoes_venda.Controls.Add(this.lbl_id_venda);
            this.grp_informacoes_venda.Controls.Add(this.lbl_valor_unitario);
            this.grp_informacoes_venda.Controls.Add(this.lbl_descricao);
            this.grp_informacoes_venda.Controls.Add(this.lbl_quantidade);
            this.grp_informacoes_venda.Controls.Add(this.txt_valor_unitario);
            this.grp_informacoes_venda.Controls.Add(this.txt_id_venda);
            this.grp_informacoes_venda.Controls.Add(this.txt_quantidade);
            this.grp_informacoes_venda.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_informacoes_venda.Location = new System.Drawing.Point(15, 12);
            this.grp_informacoes_venda.Name = "grp_informacoes_venda";
            this.grp_informacoes_venda.Size = new System.Drawing.Size(653, 150);
            this.grp_informacoes_venda.TabIndex = 11;
            this.grp_informacoes_venda.TabStop = false;
            this.grp_informacoes_venda.Text = "Informações da Venda:";
            // 
            // lbl_qnt_item_selecionado
            // 
            this.lbl_qnt_item_selecionado.AutoSize = true;
            this.lbl_qnt_item_selecionado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qnt_item_selecionado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qnt_item_selecionado.Location = new System.Drawing.Point(133, 38);
            this.lbl_qnt_item_selecionado.Name = "lbl_qnt_item_selecionado";
            this.lbl_qnt_item_selecionado.Size = new System.Drawing.Size(228, 18);
            this.lbl_qnt_item_selecionado.TabIndex = 12;
            this.lbl_qnt_item_selecionado.Text = "Quantidade (Item Selecionado):";
            // 
            // txt_qnt_item_selecionado
            // 
            this.txt_qnt_item_selecionado.Enabled = false;
            this.txt_qnt_item_selecionado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qnt_item_selecionado.Location = new System.Drawing.Point(367, 35);
            this.txt_qnt_item_selecionado.Name = "txt_qnt_item_selecionado";
            this.txt_qnt_item_selecionado.Size = new System.Drawing.Size(105, 26);
            this.txt_qnt_item_selecionado.TabIndex = 13;
            // 
            // grp_sistema
            // 
            this.grp_sistema.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_sistema.BackColor = System.Drawing.Color.Transparent;
            this.grp_sistema.Controls.Add(this.lbl_itens_sistema_resultado);
            this.grp_sistema.Controls.Add(this.lbl_total_resultado);
            this.grp_sistema.Controls.Add(this.lbl_itens_sistema);
            this.grp_sistema.Controls.Add(this.lbl_total);
            this.grp_sistema.Controls.Add(this.txt_qnt_item_selecionado);
            this.grp_sistema.Controls.Add(this.lbl_qnt_item_selecionado);
            this.grp_sistema.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_sistema.Location = new System.Drawing.Point(15, 599);
            this.grp_sistema.Name = "grp_sistema";
            this.grp_sistema.Size = new System.Drawing.Size(653, 164);
            this.grp_sistema.TabIndex = 14;
            this.grp_sistema.TabStop = false;
            this.grp_sistema.Text = "Sistema:";
            // 
            // lbl_itens_sistema_resultado
            // 
            this.lbl_itens_sistema_resultado.AutoSize = true;
            this.lbl_itens_sistema_resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itens_sistema_resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens_sistema_resultado.Location = new System.Drawing.Point(355, 118);
            this.lbl_itens_sistema_resultado.Name = "lbl_itens_sistema_resultado";
            this.lbl_itens_sistema_resultado.Size = new System.Drawing.Size(17, 18);
            this.lbl_itens_sistema_resultado.TabIndex = 19;
            this.lbl_itens_sistema_resultado.Text = "0";
            // 
            // lbl_total_resultado
            // 
            this.lbl_total_resultado.AutoSize = true;
            this.lbl_total_resultado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total_resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_resultado.Location = new System.Drawing.Point(306, 80);
            this.lbl_total_resultado.Name = "lbl_total_resultado";
            this.lbl_total_resultado.Size = new System.Drawing.Size(39, 18);
            this.lbl_total_resultado.TabIndex = 18;
            this.lbl_total_resultado.Text = "0,00";
            // 
            // lbl_itens_sistema
            // 
            this.lbl_itens_sistema.AutoSize = true;
            this.lbl_itens_sistema.BackColor = System.Drawing.Color.Transparent;
            this.lbl_itens_sistema.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itens_sistema.Location = new System.Drawing.Point(222, 118);
            this.lbl_itens_sistema.Name = "lbl_itens_sistema";
            this.lbl_itens_sistema.Size = new System.Drawing.Size(127, 18);
            this.lbl_itens_sistema.TabIndex = 16;
            this.lbl_itens_sistema.Text = "Itens no Sistema:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(253, 80);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 18);
            this.lbl_total.TabIndex = 14;
            this.lbl_total.Text = "Total:";
            // 
            // btn_sair
            // 
            this.btn_sair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sair.BackColor = System.Drawing.Color.Purple;
            this.btn_sair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(455, 791);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(111, 47);
            this.btn_sair.TabIndex = 16;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_alterar.BackColor = System.Drawing.Color.Blue;
            this.btn_alterar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(104, 791);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(111, 47);
            this.btn_alterar.TabIndex = 15;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_nova_venda
            // 
            this.btn_nova_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_nova_venda.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_nova_venda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nova_venda.ForeColor = System.Drawing.Color.White;
            this.btn_nova_venda.Location = new System.Drawing.Point(338, 791);
            this.btn_nova_venda.Name = "btn_nova_venda";
            this.btn_nova_venda.Size = new System.Drawing.Size(111, 47);
            this.btn_nova_venda.TabIndex = 18;
            this.btn_nova_venda.Text = "Nova Venda";
            this.btn_nova_venda.UseVisualStyleBackColor = false;
            this.btn_nova_venda.Click += new System.EventHandler(this.btn_nova_venda_Click);
            // 
            // btn_cancelar_venda
            // 
            this.btn_cancelar_venda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar_venda.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cancelar_venda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar_venda.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar_venda.Location = new System.Drawing.Point(221, 791);
            this.btn_cancelar_venda.Name = "btn_cancelar_venda";
            this.btn_cancelar_venda.Size = new System.Drawing.Size(111, 47);
            this.btn_cancelar_venda.TabIndex = 17;
            this.btn_cancelar_venda.Text = "Cancelar Venda";
            this.btn_cancelar_venda.UseVisualStyleBackColor = false;
            this.btn_cancelar_venda.Click += new System.EventHandler(this.btn_cancelar_venda_Click);
            // 
            // frm_mercadinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 857);
            this.ControlBox = false;
            this.Controls.Add(this.btn_nova_venda);
            this.Controls.Add(this.btn_cancelar_venda);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.grp_sistema);
            this.Controls.Add(this.grp_informacoes_venda);
            this.Controls.Add(this.dgv_carrinho_de_compras);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_inserir);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_mercadinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema: Mercadinho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrinho_de_compras)).EndInit();
            this.grp_informacoes_venda.ResumeLayout(false);
            this.grp_informacoes_venda.PerformLayout();
            this.grp_sistema.ResumeLayout(false);
            this.grp_sistema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_id_venda;
        private System.Windows.Forms.Label lbl_valor_unitario;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_id_venda;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txt_valor_unitario;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.DataGridView dgv_carrinho_de_compras;
        private System.Windows.Forms.GroupBox grp_informacoes_venda;
        private System.Windows.Forms.Label lbl_qnt_item_selecionado;
        private System.Windows.Forms.TextBox txt_qnt_item_selecionado;
        private System.Windows.Forms.GroupBox grp_sistema;
        private System.Windows.Forms.Label lbl_itens_sistema;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_total_resultado;
        private System.Windows.Forms.Label lbl_itens_sistema_resultado;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_nova_venda;
        private System.Windows.Forms.Button btn_cancelar_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_valor_unitario;
    }
}

