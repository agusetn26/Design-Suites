
namespace sistemaPrincipal
{
    partial class transacciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transacciones));
            this.panelEstructura = new System.Windows.Forms.TableLayoutPanel();
            this.backBoton = new System.Windows.Forms.Button();
            this.contenedorHoteles = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEstructura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstructura
            // 
            this.panelEstructura.BackColor = System.Drawing.Color.Transparent;
            this.panelEstructura.ColumnCount = 3;
            this.panelEstructura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEstructura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelEstructura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEstructura.Controls.Add(this.backBoton, 0, 0);
            this.panelEstructura.Controls.Add(this.contenedorHoteles, 1, 1);
            this.panelEstructura.Controls.Add(this.label1, 1, 0);
            this.panelEstructura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstructura.Location = new System.Drawing.Point(0, 0);
            this.panelEstructura.Name = "panelEstructura";
            this.panelEstructura.RowCount = 2;
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelEstructura.Size = new System.Drawing.Size(800, 380);
            this.panelEstructura.TabIndex = 1;
            // 
            // backBoton
            // 
            this.backBoton.BackColor = System.Drawing.Color.Transparent;
            this.backBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBoton.BackgroundImage")));
            this.backBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBoton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backBoton.FlatAppearance.BorderSize = 0;
            this.backBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBoton.ForeColor = System.Drawing.Color.White;
            this.backBoton.Location = new System.Drawing.Point(3, 3);
            this.backBoton.Name = "backBoton";
            this.backBoton.Size = new System.Drawing.Size(154, 70);
            this.backBoton.TabIndex = 0;
            this.backBoton.UseVisualStyleBackColor = false;
            this.backBoton.Click += new System.EventHandler(this.back);
            // 
            // contenedorHoteles
            // 
            this.contenedorHoteles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contenedorHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contenedorHoteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorHoteles.Location = new System.Drawing.Point(163, 79);
            this.contenedorHoteles.Name = "contenedorHoteles";
            this.contenedorHoteles.Size = new System.Drawing.Size(474, 298);
            this.contenedorHoteles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA DE TRANSACCIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.panelEstructura);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transacciones";
            this.Text = "Form1";
            this.panelEstructura.ResumeLayout(false);
            this.panelEstructura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorHoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelEstructura;
        private System.Windows.Forms.Button backBoton;
        private System.Windows.Forms.DataGridView contenedorHoteles;
        private System.Windows.Forms.Label label1;
    }
}