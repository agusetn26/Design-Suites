
namespace sistemaPrincipal
{
    partial class builderForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(builderForm));
            this.atomixIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hoteles = new System.Windows.Forms.Button();
            this.transacciones = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.atomixIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // atomixIcon
            // 
            this.atomixIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atomixIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(134)))), ((int)(((byte)(209)))));
            this.atomixIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.atomixIcon.Image = ((System.Drawing.Image)(resources.GetObject("atomixIcon.Image")));
            this.atomixIcon.Location = new System.Drawing.Point(183, 101);
            this.atomixIcon.Name = "atomixIcon";
            this.atomixIcon.Size = new System.Drawing.Size(310, 303);
            this.atomixIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atomixIcon.TabIndex = 0;
            this.atomixIcon.TabStop = false;
            this.atomixIcon.Click += new System.EventHandler(this.atomixIcon_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Design Suites";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // hoteles
            // 
            this.hoteles.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.hoteles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.hoteles.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoteles.Location = new System.Drawing.Point(11, 124);
            this.hoteles.Name = "hoteles";
            this.hoteles.Size = new System.Drawing.Size(215, 94);
            this.hoteles.TabIndex = 2;
            this.hoteles.Text = "HOTELES";
            this.hoteles.UseVisualStyleBackColor = true;
            this.hoteles.Click += new System.EventHandler(this.button1_Click);
            // 
            // transacciones
            // 
            this.transacciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.transacciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transacciones.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacciones.Location = new System.Drawing.Point(452, 124);
            this.transacciones.Name = "transacciones";
            this.transacciones.Size = new System.Drawing.Size(215, 94);
            this.transacciones.TabIndex = 3;
            this.transacciones.Text = "TRANSACCIONES";
            this.transacciones.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 94);
            this.button2.TabIndex = 4;
            this.button2.Text = "PROVEEDORES";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(452, 300);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 94);
            this.button3.TabIndex = 5;
            this.button3.Text = "PRODUCTOS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // builderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(134)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(679, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.transacciones);
            this.Controls.Add(this.hoteles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atomixIcon);
            this.Name = "builderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSMS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atomixIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox atomixIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hoteles;
        private System.Windows.Forms.Button transacciones;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

