
namespace encuestador
{
    partial class frmVerEncuesta
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVerEncuesta = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
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
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(125, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.sesionToolStripMenuItem.Text = "Volver";
            this.sesionToolStripMenuItem.Click += new System.EventHandler(this.sesionToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnVerEncuesta, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(662, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.31579F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.68421F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 95);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnVerEncuesta
            // 
            this.btnVerEncuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVerEncuesta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVerEncuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEncuesta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerEncuesta.Location = new System.Drawing.Point(3, 3);
            this.btnVerEncuesta.Name = "btnVerEncuesta";
            this.btnVerEncuesta.Size = new System.Drawing.Size(124, 37);
            this.btnVerEncuesta.TabIndex = 0;
            this.btnVerEncuesta.Text = "Ver Encuesta";
            this.btnVerEncuesta.UseVisualStyleBackColor = false;
            this.btnVerEncuesta.Click += new System.EventHandler(this.btnVerEncuesta_Click);
            // 
            // lblEncuestas
            // 
            this.lblEncuestas.AutoSize = true;
            this.lblEncuestas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEncuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuestas.Location = new System.Drawing.Point(128, 0);
            this.lblEncuestas.Name = "lblEncuestas";
            this.lblEncuestas.Size = new System.Drawing.Size(528, 101);
            this.lblEncuestas.TabIndex = 3;
            this.lblEncuestas.Text = "Ver Encuestas ";
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
            this.dgvEncuestas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncuestas_CellContentClick_1);
            // 
            // frmVerEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmVerEncuesta";
            this.Text = "Ver Encuesta";
            this.Load += new System.EventHandler(this.frmVerEncuesta_Load);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVerEncuesta;
        private System.Windows.Forms.Label lblEncuestas;
        private System.Windows.Forms.DataGridView dgvEncuestas;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
    }
}