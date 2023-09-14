
namespace sistemaPrincipal
{
    partial class formularioProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioProducto));
            this.panelEstructura = new System.Windows.Forms.TableLayoutPanel();
            this.backBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.categoria = new System.Windows.Forms.TextBox();
            this.productoNombre = new System.Windows.Forms.TextBox();
            this.coste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.displayImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelEstructura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
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
            this.panelEstructura.Controls.Add(this.label1, 1, 0);
            this.panelEstructura.Controls.Add(this.pictureBox1, 2, 0);
            this.panelEstructura.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.panelEstructura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstructura.Location = new System.Drawing.Point(0, 0);
            this.panelEstructura.Name = "panelEstructura";
            this.panelEstructura.RowCount = 2;
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.28739F));
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.71261F));
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelEstructura.Size = new System.Drawing.Size(784, 341);
            this.panelEstructura.TabIndex = 2;
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
            this.backBoton.Size = new System.Drawing.Size(150, 69);
            this.backBoton.TabIndex = 0;
            this.backBoton.UseVisualStyleBackColor = false;
            this.backBoton.Click += new System.EventHandler(this.back);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(159, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 75);
            this.label1.TabIndex = 3;
            this.label1.Text = "RELLENE FORMULARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.panelEstructura.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 260);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.proveedores, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.categoria, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.productoNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.coste, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(383, 254);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // proveedores
            // 
            this.proveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.proveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Items.AddRange(new object[] {
            "pequeño",
            "mediano",
            "grande"});
            this.proveedores.Location = new System.Drawing.Point(201, 143);
            this.proveedores.Margin = new System.Windows.Forms.Padding(0);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(171, 28);
            this.proveedores.TabIndex = 19;
            // 
            // categoria
            // 
            this.categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(191, 79);
            this.categoria.Margin = new System.Windows.Forms.Padding(0);
            this.categoria.MaxLength = 200;
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(192, 31);
            this.categoria.TabIndex = 8;
            this.categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productoNombre
            // 
            this.productoNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoNombre.Location = new System.Drawing.Point(191, 16);
            this.productoNombre.Margin = new System.Windows.Forms.Padding(0);
            this.productoNombre.MaxLength = 200;
            this.productoNombre.Name = "productoNombre";
            this.productoNombre.Size = new System.Drawing.Size(192, 31);
            this.productoNombre.TabIndex = 7;
            this.productoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coste
            // 
            this.coste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coste.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coste.Location = new System.Drawing.Point(191, 206);
            this.coste.Margin = new System.Windows.Forms.Padding(0);
            this.coste.MaxLength = 200;
            this.coste.Name = "coste";
            this.coste.Size = new System.Drawing.Size(192, 31);
            this.coste.TabIndex = 12;
            this.coste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 59);
            this.label5.TabIndex = 11;
            this.label5.Text = "Coste Unitario:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proveedor:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 57);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.displayImage, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(392, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(383, 254);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // displayImage
            // 
            this.displayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayImage.Location = new System.Drawing.Point(3, 3);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(377, 209);
            this.displayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.displayImage.TabIndex = 2;
            this.displayImage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Seleccionar imagenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formularioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.panelEstructura);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioProducto";
            this.Text = "Form1";
            this.panelEstructura.ResumeLayout(false);
            this.panelEstructura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelEstructura;
        private System.Windows.Forms.Button backBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.TextBox categoria;
        private System.Windows.Forms.TextBox productoNombre;
        private System.Windows.Forms.TextBox coste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox displayImage;
        private System.Windows.Forms.Button button1;
    }
}