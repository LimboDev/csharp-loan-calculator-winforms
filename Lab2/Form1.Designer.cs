namespace Lab2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLimpiarCampos = new System.Windows.Forms.Button();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.lbCuota = new System.Windows.Forms.Label();
            this.lbEvaluado = new System.Windows.Forms.Label();
            this.lbDatos = new System.Windows.Forms.Label();
            this.btEvaluar = new System.Windows.Forms.Button();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrestamo = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Evaluación de Préstamos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btLimpiarCampos);
            this.groupBox1.Controls.Add(this.lbPorcentaje);
            this.groupBox1.Controls.Add(this.lbCuota);
            this.groupBox1.Controls.Add(this.lbEvaluado);
            this.groupBox1.Controls.Add(this.lbDatos);
            this.groupBox1.Controls.Add(this.btEvaluar);
            this.groupBox1.Controls.Add(this.cbPlazo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbPrestamo);
            this.groupBox1.Controls.Add(this.tbSalario);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(50, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Solicitante";
            // 
            // btLimpiarCampos
            // 
            this.btLimpiarCampos.BackColor = System.Drawing.SystemColors.Menu;
            this.btLimpiarCampos.Location = new System.Drawing.Point(152, 263);
            this.btLimpiarCampos.Name = "btLimpiarCampos";
            this.btLimpiarCampos.Size = new System.Drawing.Size(169, 32);
            this.btLimpiarCampos.TabIndex = 14;
            this.btLimpiarCampos.Text = "Limpiar Campos";
            this.btLimpiarCampos.UseVisualStyleBackColor = false;
            this.btLimpiarCampos.Click += new System.EventHandler(this.btLimpiarCampos_Click);
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Location = new System.Drawing.Point(541, 162);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(0, 20);
            this.lbPorcentaje.TabIndex = 13;
            // 
            // lbCuota
            // 
            this.lbCuota.AutoSize = true;
            this.lbCuota.Location = new System.Drawing.Point(541, 124);
            this.lbCuota.Name = "lbCuota";
            this.lbCuota.Size = new System.Drawing.Size(0, 20);
            this.lbCuota.TabIndex = 12;
            // 
            // lbEvaluado
            // 
            this.lbEvaluado.AutoSize = true;
            this.lbEvaluado.Location = new System.Drawing.Point(541, 84);
            this.lbEvaluado.Name = "lbEvaluado";
            this.lbEvaluado.Size = new System.Drawing.Size(0, 20);
            this.lbEvaluado.TabIndex = 11;
            // 
            // lbDatos
            // 
            this.lbDatos.AutoSize = true;
            this.lbDatos.Location = new System.Drawing.Point(541, 45);
            this.lbDatos.Name = "lbDatos";
            this.lbDatos.Size = new System.Drawing.Size(0, 20);
            this.lbDatos.TabIndex = 10;
            // 
            // btEvaluar
            // 
            this.btEvaluar.BackColor = System.Drawing.SystemColors.Menu;
            this.btEvaluar.Enabled = false;
            this.btEvaluar.Location = new System.Drawing.Point(468, 263);
            this.btEvaluar.Name = "btEvaluar";
            this.btEvaluar.Size = new System.Drawing.Size(85, 32);
            this.btEvaluar.TabIndex = 9;
            this.btEvaluar.Text = "Evaluar";
            this.btEvaluar.UseVisualStyleBackColor = false;
            this.btEvaluar.Click += new System.EventHandler(this.btEvaluar_Click);
            // 
            // cbPlazo
            // 
            this.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Items.AddRange(new object[] {
            "12 meses",
            "24 meses",
            "36 meses"});
            this.cbPlazo.Location = new System.Drawing.Point(305, 199);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(188, 28);
            this.cbPlazo.TabIndex = 8;
            this.cbPlazo.SelectedIndexChanged += new System.EventHandler(this.cbPlazo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Seleccione plazo del préstamo:";
            // 
            // tbPrestamo
            // 
            this.tbPrestamo.Location = new System.Drawing.Point(305, 156);
            this.tbPrestamo.MaxLength = 10;
            this.tbPrestamo.Name = "tbPrestamo";
            this.tbPrestamo.Size = new System.Drawing.Size(188, 26);
            this.tbPrestamo.TabIndex = 0;
            this.tbPrestamo.TextChanged += new System.EventHandler(this.tbPrestamo_TextChanged);
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(305, 118);
            this.tbSalario.MaxLength = 10;
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(188, 26);
            this.tbSalario.TabIndex = 6;
            this.tbSalario.TextChanged += new System.EventHandler(this.tbSalario_TextChanged);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(305, 78);
            this.tbID.MaxLength = 20;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(188, 26);
            this.tbID.TabIndex = 5;
            this.tbID.TextChanged += new System.EventHandler(this.tbID_TextChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNombre.Location = new System.Drawing.Point(305, 39);
            this.tbNombre.MaxLength = 40;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(188, 26);
            this.tbNombre.TabIndex = 4;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ingrese monto del préstamo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ingrese su salario mensual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ingrese su ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese su nombre completo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Evaluación de Préstamos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrestamo;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPlazo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDatos;
        private System.Windows.Forms.Button btEvaluar;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.Label lbCuota;
        private System.Windows.Forms.Label lbEvaluado;
        private System.Windows.Forms.Button btLimpiarCampos;
    }
}

