namespace UtilidadesUI
{
    partial class NumeroDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.butAceptar = new System.Windows.Forms.Button();
            this.butCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumero, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.butAceptar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butCancelar, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 69);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(8, 5);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 13);
            this.label.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNumero.Location = new System.Drawing.Point(129, 8);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(115, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // butAceptar
            // 
            this.butAceptar.Dock = System.Windows.Forms.DockStyle.Top;
            this.butAceptar.Location = new System.Drawing.Point(8, 34);
            this.butAceptar.Name = "butAceptar";
            this.butAceptar.Size = new System.Drawing.Size(115, 23);
            this.butAceptar.TabIndex = 2;
            this.butAceptar.Text = "Aceptar";
            this.butAceptar.UseVisualStyleBackColor = true;
            this.butAceptar.Click += new System.EventHandler(this.butAceptar_Click);
            // 
            // butCancelar
            // 
            this.butCancelar.Dock = System.Windows.Forms.DockStyle.Top;
            this.butCancelar.Location = new System.Drawing.Point(129, 34);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(115, 23);
            this.butCancelar.TabIndex = 3;
            this.butCancelar.Text = "Cancelar";
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // NumeroDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 69);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NumeroDialog";
            this.Text = "NumeroDialog";
            this.Load += new System.EventHandler(this.NumeroDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button butAceptar;
        private System.Windows.Forms.Button butCancelar;
    }
}