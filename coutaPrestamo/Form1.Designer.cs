namespace coutaPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Prestamo = new System.Windows.Forms.TextBox();
            this.txt_Periodo = new System.Windows.Forms.TextBox();
            this.txt_Cuota = new System.Windows.Forms.TextBox();
            this.txt_Tasa = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagomensual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldorestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestamo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Periodo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tasa_anual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cuota";
            // 
            // txt_Prestamo
            // 
            this.txt_Prestamo.Location = new System.Drawing.Point(301, 99);
            this.txt_Prestamo.Name = "txt_Prestamo";
            this.txt_Prestamo.Size = new System.Drawing.Size(113, 20);
            this.txt_Prestamo.TabIndex = 4;
            // 
            // txt_Periodo
            // 
            this.txt_Periodo.Location = new System.Drawing.Point(301, 145);
            this.txt_Periodo.Name = "txt_Periodo";
            this.txt_Periodo.Size = new System.Drawing.Size(113, 20);
            this.txt_Periodo.TabIndex = 5;
            // 
            // txt_Cuota
            // 
            this.txt_Cuota.Location = new System.Drawing.Point(301, 238);
            this.txt_Cuota.Name = "txt_Cuota";
            this.txt_Cuota.Size = new System.Drawing.Size(113, 20);
            this.txt_Cuota.TabIndex = 6;
            // 
            // txt_Tasa
            // 
            this.txt_Tasa.Location = new System.Drawing.Point(301, 190);
            this.txt_Tasa.Name = "txt_Tasa";
            this.txt_Tasa.Size = new System.Drawing.Size(113, 20);
            this.txt_Tasa.TabIndex = 7;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.Location = new System.Drawing.Point(517, 122);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(90, 35);
            this.btn_Calcular.TabIndex = 8;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(517, 175);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(90, 35);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(517, 225);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(90, 35);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "La Cuota de un Prestamo";
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.pagomensual,
            this.intereses,
            this.capital,
            this.saldorestante});
            this.dgv_data.Location = new System.Drawing.Point(162, 288);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(545, 150);
            this.dgv_data.TabIndex = 12;
            // 
            // periodo
            // 
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            // 
            // pagomensual
            // 
            this.pagomensual.HeaderText = "Pago Mensual";
            this.pagomensual.Name = "pagomensual";
            // 
            // intereses
            // 
            this.intereses.HeaderText = "Intereses";
            this.intereses.Name = "intereses";
            // 
            // capital
            // 
            this.capital.HeaderText = "Capital";
            this.capital.Name = "capital";
            // 
            // saldorestante
            // 
            this.saldorestante.HeaderText = "Saldo Restante";
            this.saldorestante.Name = "saldorestante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Tasa);
            this.Controls.Add(this.txt_Cuota);
            this.Controls.Add(this.txt_Periodo);
            this.Controls.Add(this.txt_Prestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Prestamo;
        private System.Windows.Forms.TextBox txt_Periodo;
        private System.Windows.Forms.TextBox txt_Cuota;
        private System.Windows.Forms.TextBox txt_Tasa;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagomensual;
        private System.Windows.Forms.DataGridViewTextBoxColumn intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn capital;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldorestante;
    }
}

