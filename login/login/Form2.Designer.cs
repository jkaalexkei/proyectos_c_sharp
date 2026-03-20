namespace login
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkMac = new System.Windows.Forms.CheckBox();
            this.chkXiami = new System.Windows.Forms.CheckBox();
            this.rdbTarjetaCredito = new System.Windows.Forms.RadioButton();
            this.rdbPayPal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO AL SISTEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkMac
            // 
            this.chkMac.AutoSize = true;
            this.chkMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMac.Location = new System.Drawing.Point(16, 29);
            this.chkMac.Name = "chkMac";
            this.chkMac.Size = new System.Drawing.Size(50, 17);
            this.chkMac.TabIndex = 1;
            this.chkMac.Text = "Mac";
            this.chkMac.UseVisualStyleBackColor = true;
            // 
            // chkXiami
            // 
            this.chkXiami.AutoSize = true;
            this.chkXiami.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXiami.Location = new System.Drawing.Point(16, 52);
            this.chkXiami.Name = "chkXiami";
            this.chkXiami.Size = new System.Drawing.Size(95, 17);
            this.chkXiami.TabIndex = 2;
            this.chkXiami.Text = "Xiami Redmi";
            this.chkXiami.UseVisualStyleBackColor = true;
            // 
            // rdbTarjetaCredito
            // 
            this.rdbTarjetaCredito.AutoSize = true;
            this.rdbTarjetaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTarjetaCredito.Location = new System.Drawing.Point(11, 29);
            this.rdbTarjetaCredito.Name = "rdbTarjetaCredito";
            this.rdbTarjetaCredito.Size = new System.Drawing.Size(109, 17);
            this.rdbTarjetaCredito.TabIndex = 3;
            this.rdbTarjetaCredito.TabStop = true;
            this.rdbTarjetaCredito.Text = "Tarjeta Credito";
            this.rdbTarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // rdbPayPal
            // 
            this.rdbPayPal.AutoSize = true;
            this.rdbPayPal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPayPal.Location = new System.Drawing.Point(139, 29);
            this.rdbPayPal.Name = "rdbPayPal";
            this.rdbPayPal.Size = new System.Drawing.Size(64, 17);
            this.rdbPayPal.TabIndex = 4;
            this.rdbPayPal.TabStop = true;
            this.rdbPayPal.Text = "PayPal";
            this.rdbPayPal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.chkMac);
            this.groupBox1.Controls.Add(this.chkXiami);
            this.groupBox1.Location = new System.Drawing.Point(29, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione productos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.rdbPayPal);
            this.groupBox2.Controls.Add(this.rdbTarjetaCredito);
            this.groupBox2.Location = new System.Drawing.Point(29, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 65);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Metodo de pago";
            // 
            // btnComprar
            // 
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(62, 272);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 7;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(210, 272);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(352, 307);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Ventana2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMac;
        private System.Windows.Forms.CheckBox chkXiami;
        private System.Windows.Forms.RadioButton rdbTarjetaCredito;
        private System.Windows.Forms.RadioButton rdbPayPal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnVolver;
    }
}