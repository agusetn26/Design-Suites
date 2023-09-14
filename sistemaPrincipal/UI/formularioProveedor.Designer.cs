
namespace sistemaPrincipal
{
    partial class formularioProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formularioProveedor));
            this.panelEstructura = new System.Windows.Forms.TableLayoutPanel();
            this.backBoton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.direccion = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contacto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oferta = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.envio = new System.Windows.Forms.TextBox();
            this.panelEstructura.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelEstructura.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.panelEstructura.Controls.Add(this.pictureBox1, 2, 0);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.direccion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.contacto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.oferta, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.envio, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 248);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // direccion
            // 
            this.direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.Location = new System.Drawing.Point(232, 56);
            this.direccion.Margin = new System.Windows.Forms.Padding(0);
            this.direccion.MaxLength = 200;
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(232, 40);
            this.direccion.TabIndex = 8;
            this.direccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(232, 8);
            this.nombre.Margin = new System.Windows.Forms.Padding(0);
            this.nombre.MaxLength = 200;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(232, 40);
            this.nombre.TabIndex = 7;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Oferta:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contacto
            // 
            this.contacto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacto.Location = new System.Drawing.Point(232, 96);
            this.contacto.Margin = new System.Windows.Forms.Padding(0);
            this.contacto.MaxLength = 200;
            this.contacto.Name = "contacto";
            this.contacto.Size = new System.Drawing.Size(232, 40);
            this.contacto.TabIndex = 10;
            this.contacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contacto:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección:";
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
            this.label2.Size = new System.Drawing.Size(226, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del proveedor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oferta
            // 
            this.oferta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oferta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oferta.Location = new System.Drawing.Point(232, 136);
            this.oferta.Margin = new System.Windows.Forms.Padding(0);
            this.oferta.MaxLength = 200;
            this.oferta.Name = "oferta";
            this.oferta.Size = new System.Drawing.Size(232, 40);
            this.oferta.TabIndex = 12;
            this.oferta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 66);
            this.label6.TabIndex = 13;
            this.label6.Text = "Forma de envío";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // envio
            // 
            this.envio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.envio.Location = new System.Drawing.Point(232, 192);
            this.envio.Margin = new System.Windows.Forms.Padding(0);
            this.envio.MaxLength = 200;
            this.envio.Name = "envio";
            this.envio.Size = new System.Drawing.Size(232, 40);
            this.envio.TabIndex = 14;
            this.envio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formularioProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.panelEstructura);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioProveedor";
            this.Text = "Form1";
            this.panelEstructura.ResumeLayout(false);
            this.panelEstructura.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelEstructura;
        private System.Windows.Forms.Button backBoton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox contacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox oferta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox envio;
    }
}