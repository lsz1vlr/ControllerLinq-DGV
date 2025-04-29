namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_filtro = new System.Windows.Forms.Label();
            this.bt_Filtrar = new System.Windows.Forms.Button();
            this.bt_Maiusculo = new System.Windows.Forms.Button();
            this.bt_agrupar = new System.Windows.Forms.Button();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.txt_filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_filtro
            // 
            this.lb_filtro.AutoSize = true;
            this.lb_filtro.Location = new System.Drawing.Point(246, 70);
            this.lb_filtro.Name = "lb_filtro";
            this.lb_filtro.Size = new System.Drawing.Size(29, 13);
            this.lb_filtro.TabIndex = 0;
            this.lb_filtro.Text = "Filtro";
            // 
            // bt_Filtrar
            // 
            this.bt_Filtrar.Location = new System.Drawing.Point(230, 127);
            this.bt_Filtrar.Name = "bt_Filtrar";
            this.bt_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.bt_Filtrar.TabIndex = 1;
            this.bt_Filtrar.Text = "Filtrar";
            this.bt_Filtrar.UseVisualStyleBackColor = true;
            this.bt_Filtrar.Click += new System.EventHandler(this.bt_Filtrar_Click);
            // 
            // bt_Maiusculo
            // 
            this.bt_Maiusculo.Location = new System.Drawing.Point(343, 127);
            this.bt_Maiusculo.Name = "bt_Maiusculo";
            this.bt_Maiusculo.Size = new System.Drawing.Size(75, 23);
            this.bt_Maiusculo.TabIndex = 2;
            this.bt_Maiusculo.Text = "Maiusculas";
            this.bt_Maiusculo.UseVisualStyleBackColor = true;
            this.bt_Maiusculo.Click += new System.EventHandler(this.bt_Maiusculo_Click);
            // 
            // bt_agrupar
            // 
            this.bt_agrupar.Location = new System.Drawing.Point(452, 127);
            this.bt_agrupar.Name = "bt_agrupar";
            this.bt_agrupar.Size = new System.Drawing.Size(75, 23);
            this.bt_agrupar.TabIndex = 3;
            this.bt_agrupar.Text = "Agrupar";
            this.bt_agrupar.UseVisualStyleBackColor = true;
            this.bt_agrupar.Click += new System.EventHandler(this.bt_agrupar_Click);
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(253, 191);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(240, 150);
            this.dgv_clientes.TabIndex = 4;
            // 
            // txt_filtro
            // 
            this.txt_filtro.Location = new System.Drawing.Point(290, 67);
            this.txt_filtro.Name = "txt_filtro";
            this.txt_filtro.Size = new System.Drawing.Size(100, 20);
            this.txt_filtro.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_filtro);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.bt_agrupar);
            this.Controls.Add(this.bt_Maiusculo);
            this.Controls.Add(this.bt_Filtrar);
            this.Controls.Add(this.lb_filtro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_filtro;
        private System.Windows.Forms.Button bt_Filtrar;
        private System.Windows.Forms.Button bt_Maiusculo;
        private System.Windows.Forms.Button bt_agrupar;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.TextBox txt_filtro;
    }
}

