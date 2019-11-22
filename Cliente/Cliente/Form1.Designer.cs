namespace Cliente
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
            this.btnAhorrar = new System.Windows.Forms.Button();
            this.btnVerSaldo = new System.Windows.Forms.Button();
            this.txtAhorrar = new System.Windows.Forms.TextBox();
            this.txtVerSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAhorrar
            // 
            this.btnAhorrar.Location = new System.Drawing.Point(34, 58);
            this.btnAhorrar.Name = "btnAhorrar";
            this.btnAhorrar.Size = new System.Drawing.Size(75, 23);
            this.btnAhorrar.TabIndex = 0;
            this.btnAhorrar.Text = "Ahorrar";
            this.btnAhorrar.UseVisualStyleBackColor = true;
            this.btnAhorrar.Click += new System.EventHandler(this.btnAhorrar_Click);
            // 
            // btnVerSaldo
            // 
            this.btnVerSaldo.Location = new System.Drawing.Point(34, 136);
            this.btnVerSaldo.Name = "btnVerSaldo";
            this.btnVerSaldo.Size = new System.Drawing.Size(75, 23);
            this.btnVerSaldo.TabIndex = 1;
            this.btnVerSaldo.Text = "Ver Saldo";
            this.btnVerSaldo.UseVisualStyleBackColor = true;
            this.btnVerSaldo.Click += new System.EventHandler(this.btnVerSaldo_Click);
            // 
            // txtAhorrar
            // 
            this.txtAhorrar.Location = new System.Drawing.Point(162, 60);
            this.txtAhorrar.Name = "txtAhorrar";
            this.txtAhorrar.Size = new System.Drawing.Size(100, 20);
            this.txtAhorrar.TabIndex = 2;
            // 
            // txtVerSaldo
            // 
            this.txtVerSaldo.Location = new System.Drawing.Point(162, 138);
            this.txtVerSaldo.Name = "txtVerSaldo";
            this.txtVerSaldo.ReadOnly = true;
            this.txtVerSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtVerSaldo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtVerSaldo);
            this.Controls.Add(this.txtAhorrar);
            this.Controls.Add(this.btnVerSaldo);
            this.Controls.Add(this.btnAhorrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAhorrar;
        private System.Windows.Forms.Button btnVerSaldo;
        private System.Windows.Forms.TextBox txtAhorrar;
        private System.Windows.Forms.TextBox txtVerSaldo;
    }
}

