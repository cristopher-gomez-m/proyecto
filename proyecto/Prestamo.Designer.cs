
namespace proyecto
{
    partial class Prestamo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonPedirPrestamo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.saludo = new System.Windows.Forms.Label();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.volver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cuotas);
            this.panel1.Controls.Add(this.botonPedirPrestamo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.valor);
            this.panel1.Controls.Add(this.P);
            this.panel1.Location = new System.Drawing.Point(73, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 185);
            this.panel1.TabIndex = 0;
            // 
            // botonPedirPrestamo
            // 
            this.botonPedirPrestamo.Location = new System.Drawing.Point(107, 134);
            this.botonPedirPrestamo.Name = "botonPedirPrestamo";
            this.botonPedirPrestamo.Size = new System.Drawing.Size(91, 48);
            this.botonPedirPrestamo.TabIndex = 3;
            this.botonPedirPrestamo.Text = "realizar prestamo";
            this.botonPedirPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonPedirPrestamo.UseVisualStyleBackColor = true;
            this.botonPedirPrestamo.Click += new System.EventHandler(this.botonPedirPrestamo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de periodos anuales: ";
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(174, 44);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 1;
            this.valor.TextChanged += new System.EventHandler(this.valor_TextChanged);
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Location = new System.Drawing.Point(20, 44);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(81, 13);
            this.P.TabIndex = 0;
            this.P.Text = "Valor a prestar: ";
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Location = new System.Drawing.Point(115, 36);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(60, 13);
            this.saludo.TabIndex = 1;
            this.saludo.Text = "Bienvenido";
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(174, 88);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(121, 21);
            this.cuotas.TabIndex = 4;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(693, 341);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.saludo);
            this.Controls.Add(this.panel1);
            this.Name = "Prestamo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Button botonPedirPrestamo;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}