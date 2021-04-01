
namespace encuestador.forms
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEncuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEncuestas = new System.Windows.Forms.Label();
            this.dgvEncuestas = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.9759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.02409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEncuestas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEncuestas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem,
            this.encuestaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // encuestaToolStripMenuItem
            // 
            this.encuestaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaEncuestaToolStripMenuItem,
            this.visualizarEncuestasToolStripMenuItem,
            this.aplicarEncuestaToolStripMenuItem});
            this.encuestaToolStripMenuItem.Name = "encuestaToolStripMenuItem";
            this.encuestaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.encuestaToolStripMenuItem.Text = "Encuesta";
            // 
            // crearNuevaEncuestaToolStripMenuItem
            // 
            this.crearNuevaEncuestaToolStripMenuItem.Name = "crearNuevaEncuestaToolStripMenuItem";
            this.crearNuevaEncuestaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.crearNuevaEncuestaToolStripMenuItem.Text = "Crear Nueva Encuesta";
            this.crearNuevaEncuestaToolStripMenuItem.Click += new System.EventHandler(this.crearNuevaEncuestaToolStripMenuItem_Click);
            // 
            // visualizarEncuestasToolStripMenuItem
            // 
            this.visualizarEncuestasToolStripMenuItem.Name = "visualizarEncuestasToolStripMenuItem";
            this.visualizarEncuestasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.visualizarEncuestasToolStripMenuItem.Text = "Visualizar Encuestas";
            // 
            // aplicarEncuestaToolStripMenuItem
            // 
            this.aplicarEncuestaToolStripMenuItem.Name = "aplicarEncuestaToolStripMenuItem";
            this.aplicarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aplicarEncuestaToolStripMenuItem.Text = "Aplicar Encuesta";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnEditar, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(665, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.68421F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 95);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(3, 46);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 46);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(3, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 37);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEncuestas
            // 
            this.lblEncuestas.AutoSize = true;
            this.lblEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuestas.Location = new System.Drawing.Point(128, 0);
            this.lblEncuestas.Name = "lblEncuestas";
            this.lblEncuestas.Size = new System.Drawing.Size(531, 101);
            this.lblEncuestas.TabIndex = 3;
            this.lblEncuestas.Text = "Encuestas creadas";
            this.lblEncuestas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvEncuestas
            // 
            this.dgvEncuestas.AllowUserToAddRows = false;
            this.dgvEncuestas.AllowUserToDeleteRows = false;
            this.dgvEncuestas.AllowUserToResizeColumns = false;
            this.dgvEncuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEncuestas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEncuestas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvEncuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvEncuestas, 3);
            this.dgvEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEncuestas.Location = new System.Drawing.Point(3, 104);
            this.dgvEncuestas.Name = "dgvEncuestas";
            this.dgvEncuestas.ReadOnly = true;
            this.dgvEncuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEncuestas.Size = new System.Drawing.Size(794, 343);
            this.dgvEncuestas.TabIndex = 0;
            this.dgvEncuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncuestas_CellContentClick);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Encuestas";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncuestas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEncuestas;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEncuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicarEncuestaToolStripMenuItem;
    }
}