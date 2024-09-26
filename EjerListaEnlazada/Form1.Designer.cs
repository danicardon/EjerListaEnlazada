namespace EjerListaEnlazada
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarGanadores = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grGanadores = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.grCorredores = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RANDOM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCorredores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarGanadores
            // 
            this.btnListarGanadores.Location = new System.Drawing.Point(486, 228);
            this.btnListarGanadores.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarGanadores.Name = "btnListarGanadores";
            this.btnListarGanadores.Size = new System.Drawing.Size(98, 42);
            this.btnListarGanadores.TabIndex = 17;
            this.btnListarGanadores.Text = "Listar &Ganadores";
            this.btnListarGanadores.UseVisualStyleBackColor = true;
            this.btnListarGanadores.Click += new System.EventHandler(this.btnListarGanadores_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(368, 409);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(66, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Corredores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ganadores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Corredores";
            // 
            // grGanadores
            // 
            this.grGanadores.AllowUserToAddRows = false;
            this.grGanadores.AllowUserToDeleteRows = false;
            this.grGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grGanadores.Location = new System.Drawing.Point(22, 228);
            this.grGanadores.Margin = new System.Windows.Forms.Padding(2);
            this.grGanadores.Name = "grGanadores";
            this.grGanadores.ReadOnly = true;
            this.grGanadores.RowHeadersVisible = false;
            this.grGanadores.RowTemplate.Height = 24;
            this.grGanadores.Size = new System.Drawing.Size(442, 170);
            this.grGanadores.TabIndex = 12;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Numero";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Participaciones";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Carreras Ganadas";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(486, 401);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 43);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(486, 31);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 41);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "&Listar Corredores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // grCorredores
            // 
            this.grCorredores.AllowUserToAddRows = false;
            this.grCorredores.AllowUserToDeleteRows = false;
            this.grCorredores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grCorredores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.grCorredores.Location = new System.Drawing.Point(22, 31);
            this.grCorredores.Margin = new System.Windows.Forms.Padding(2);
            this.grCorredores.Name = "grCorredores";
            this.grCorredores.ReadOnly = true;
            this.grCorredores.RowHeadersVisible = false;
            this.grCorredores.RowTemplate.Height = 24;
            this.grCorredores.Size = new System.Drawing.Size(442, 179);
            this.grCorredores.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Participaciones";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Carreras Ganadas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // RANDOM
            // 
            this.RANDOM.Location = new System.Drawing.Point(22, 417);
            this.RANDOM.Name = "RANDOM";
            this.RANDOM.Size = new System.Drawing.Size(87, 60);
            this.RANDOM.TabIndex = 18;
            this.RANDOM.Text = "Generar Participantes";
            this.RANDOM.UseVisualStyleBackColor = true;
            this.RANDOM.Click += new System.EventHandler(this.RANDOM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 489);
            this.Controls.Add(this.RANDOM);
            this.Controls.Add(this.btnListarGanadores);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grGanadores);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.grCorredores);
            this.Name = "Form1";
            this.Text = "Carreras";
            ((System.ComponentModel.ISupportInitialize)(this.grGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grCorredores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarGanadores;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView grCorredores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button RANDOM;
    }
}

