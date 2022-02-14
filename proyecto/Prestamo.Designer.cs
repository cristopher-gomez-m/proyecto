
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
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.botonPedirPrestamo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.saludo = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.cuotas);
            this.panel1.Controls.Add(this.botonPedirPrestamo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.valor);
            this.panel1.Controls.Add(this.P);
            this.panel1.Location = new System.Drawing.Point(65, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 197);
            this.panel1.TabIndex = 0;
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(189, 88);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(121, 21);
            this.cuotas.TabIndex = 4;
            this.cuotas.SelectedIndexChanged += new System.EventHandler(this.cuotas_SelectedIndexChanged);
            // 
            // botonPedirPrestamo
            // 
            this.botonPedirPrestamo.BackColor = System.Drawing.SystemColors.Window;
            this.botonPedirPrestamo.Location = new System.Drawing.Point(226, 125);
            this.botonPedirPrestamo.Name = "botonPedirPrestamo";
            this.botonPedirPrestamo.Size = new System.Drawing.Size(91, 48);
            this.botonPedirPrestamo.TabIndex = 3;
            this.botonPedirPrestamo.Text = "Realizar prestamo";
            this.botonPedirPrestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonPedirPrestamo.UseVisualStyleBackColor = false;
            this.botonPedirPrestamo.Click += new System.EventHandler(this.botonPedirPrestamo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de periodos anuales: ";
            // 
            // valor
            // 
            this.valor.BackColor = System.Drawing.SystemColors.Window;
            this.valor.Location = new System.Drawing.Point(188, 44);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 1;
            this.valor.TextChanged += new System.EventHandler(this.valor_TextChanged);
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(14, 44);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(103, 16);
            this.P.TabIndex = 0;
            this.P.Text = "Valor a prestar: ";
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.saludo.Location = new System.Drawing.Point(35, 32);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(86, 17);
            this.saludo.TabIndex = 1;
            this.saludo.Text = "BIENVENIDO";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(389, 319);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(527, 386);
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