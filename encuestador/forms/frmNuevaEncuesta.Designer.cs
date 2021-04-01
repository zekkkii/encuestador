
namespace encuestador.forms
{
    partial class frmNuevaEncuesta
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
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.nudNumeroPreguntas = new System.Windows.Forms.NumericUpDown();
            this.btnCrearEncuesta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(107, 82);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(228, 20);
            this.tbxTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(131, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo nueva encuesta";
            // 
            // nudNumeroPreguntas
            // 
            this.nudNumeroPreguntas.Location = new System.Drawing.Point(162, 127);
            this.nudNumeroPreguntas.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudNumeroPreguntas.Name = "nudNumeroPreguntas";
            this.nudNumeroPreguntas.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroPreguntas.TabIndex = 2;
            this.nudNumeroPreguntas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
     
            // 
            // btnCrearEncuesta
            // 
            this.btnCrearEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCrearEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEncuesta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearEncuesta.Location = new System.Drawing.Point(246, 164);
            this.btnCrearEncuesta.Name = "btnCrearEncuesta";
            this.btnCrearEncuesta.Size = new System.Drawing.Size(89, 31);
            this.btnCrearEncuesta.TabIndex = 3;
            this.btnCrearEncuesta.Text = "Crear";
            this.btnCrearEncuesta.UseVisualStyleBackColor = false;
            this.btnCrearEncuesta.Click += new System.EventHandler(this.btnCrearEncuesta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(107, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 238);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearEncuesta);
            this.Controls.Add(this.nudNumeroPreguntas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tbxTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNuevaEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Encuesta";
            this.Load += new System.EventHandler(this.frmNuevaEncuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown nudNumeroPreguntas;
        private System.Windows.Forms.Button btnCrearEncuesta;
        private System.Windows.Forms.Button btnCancelar;
    }
}