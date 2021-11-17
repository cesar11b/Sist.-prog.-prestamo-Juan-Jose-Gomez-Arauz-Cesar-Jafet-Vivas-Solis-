
namespace CalculoPag
{
    partial class FrmPago
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoCuota = new System.Windows.Forms.ComboBox();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.dtpFechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.nudTerminos = new System.Windows.Forms.NumericUpDown();
            this.nudTasa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoCuota
            // 
            this.cmbTipoCuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuota.FormattingEnabled = true;
            this.cmbTipoCuota.Items.AddRange(new object[] {
            "Regular",
            "Seguro",
            "Prima"});
            this.cmbTipoCuota.Location = new System.Drawing.Point(152, 24);
            this.cmbTipoCuota.Name = "cmbTipoCuota";
            this.cmbTipoCuota.Size = new System.Drawing.Size(121, 23);
            this.cmbTipoCuota.TabIndex = 0;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(153, 78);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaPago.TabIndex = 1;
            // 
            // dtpFechavencimiento
            // 
            this.dtpFechavencimiento.Location = new System.Drawing.Point(153, 136);
            this.dtpFechavencimiento.Name = "dtpFechavencimiento";
            this.dtpFechavencimiento.Size = new System.Drawing.Size(200, 23);
            this.dtpFechavencimiento.TabIndex = 2;
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(153, 192);
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(120, 23);
            this.nudMonto.TabIndex = 3;
            // 
            // nudTerminos
            // 
            this.nudTerminos.Location = new System.Drawing.Point(153, 251);
            this.nudTerminos.Name = "nudTerminos";
            this.nudTerminos.Size = new System.Drawing.Size(120, 23);
            this.nudTerminos.TabIndex = 4;
            // 
            // nudTasa
            // 
            this.nudTasa.Location = new System.Drawing.Point(153, 307);
            this.nudTasa.Name = "nudTasa";
            this.nudTasa.Size = new System.Drawing.Size(120, 23);
            this.nudTasa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha de vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Terminos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de pago";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(401, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(213, 426);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTasa);
            this.Controls.Add(this.nudTerminos);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.dtpFechavencimiento);
            this.Controls.Add(this.dtpFechaPago);
            this.Controls.Add(this.cmbTipoCuota);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTerminos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoCuota;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.DateTimePicker dtpFechavencimiento;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.NumericUpDown nudTerminos;
        private System.Windows.Forms.NumericUpDown nudTasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

