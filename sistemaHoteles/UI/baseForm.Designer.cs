namespace sistemaHoteles
{
    partial class baseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(baseForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.eventos = new System.Windows.Forms.Button();
            this.habitaciones = new System.Windows.Forms.Button();
            this.suministros = new System.Windows.Forms.Button();
            this.reservas = new System.Windows.Forms.Button();
            this.btnHoteles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstHotel = new System.Windows.Forms.ComboBox();
            this.basePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.eventos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.habitaciones, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.suministros, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.reservas, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnHoteles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstHotel, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(178, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // eventos
            // 
            this.eventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventos.FlatAppearance.BorderSize = 0;
            this.eventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventos.ForeColor = System.Drawing.Color.White;
            this.eventos.Location = new System.Drawing.Point(0, 325);
            this.eventos.Margin = new System.Windows.Forms.Padding(0);
            this.eventos.Name = "eventos";
            this.eventos.Size = new System.Drawing.Size(178, 50);
            this.eventos.TabIndex = 6;
            this.eventos.Text = "Eventos";
            this.eventos.UseVisualStyleBackColor = true;
            this.eventos.Click += new System.EventHandler(this.eventos_Click);
            // 
            // habitaciones
            // 
            this.habitaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.habitaciones.FlatAppearance.BorderSize = 0;
            this.habitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.habitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitaciones.ForeColor = System.Drawing.Color.White;
            this.habitaciones.Location = new System.Drawing.Point(0, 275);
            this.habitaciones.Margin = new System.Windows.Forms.Padding(0);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(178, 50);
            this.habitaciones.TabIndex = 4;
            this.habitaciones.Text = "Habitaciones";
            this.habitaciones.UseVisualStyleBackColor = true;
            this.habitaciones.Click += new System.EventHandler(this.habitaciones_Click);
            // 
            // suministros
            // 
            this.suministros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suministros.FlatAppearance.BorderSize = 0;
            this.suministros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suministros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suministros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suministros.ForeColor = System.Drawing.Color.White;
            this.suministros.Location = new System.Drawing.Point(0, 225);
            this.suministros.Margin = new System.Windows.Forms.Padding(0);
            this.suministros.Name = "suministros";
            this.suministros.Size = new System.Drawing.Size(178, 50);
            this.suministros.TabIndex = 3;
            this.suministros.Text = "Suministros";
            this.suministros.UseVisualStyleBackColor = true;
            this.suministros.Click += new System.EventHandler(this.suministros_Click);
            // 
            // reservas
            // 
            this.reservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservas.FlatAppearance.BorderSize = 0;
            this.reservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservas.ForeColor = System.Drawing.Color.White;
            this.reservas.Location = new System.Drawing.Point(0, 175);
            this.reservas.Margin = new System.Windows.Forms.Padding(0);
            this.reservas.Name = "reservas";
            this.reservas.Size = new System.Drawing.Size(178, 50);
            this.reservas.TabIndex = 2;
            this.reservas.Text = "Reservas";
            this.reservas.UseVisualStyleBackColor = true;
            this.reservas.Click += new System.EventHandler(this.reservas_Click);
            // 
            // btnHoteles
            // 
            this.btnHoteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoteles.FlatAppearance.BorderSize = 0;
            this.btnHoteles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHoteles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoteles.ForeColor = System.Drawing.Color.White;
            this.btnHoteles.Location = new System.Drawing.Point(0, 125);
            this.btnHoteles.Margin = new System.Windows.Forms.Padding(0);
            this.btnHoteles.Name = "btnHoteles";
            this.btnHoteles.Size = new System.Drawing.Size(178, 50);
            this.btnHoteles.TabIndex = 1;
            this.btnHoteles.Text = "Hotel";
            this.btnHoteles.UseVisualStyleBackColor = true;
            this.btnHoteles.Click += new System.EventHandler(this.btnHoteles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lstHotel
            // 
            this.lstHotel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstHotel.FormattingEnabled = true;
            this.lstHotel.Location = new System.Drawing.Point(28, 402);
            this.lstHotel.Name = "lstHotel";
            this.lstHotel.Size = new System.Drawing.Size(121, 21);
            this.lstHotel.TabIndex = 0;
            this.lstHotel.SelectionChangeCommitted += new System.EventHandler(this.lstHotel_SelectionChangeCommitted);
            // 
            // basePanel
            // 
            this.basePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("basePanel.BackgroundImage")));
            this.basePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(178, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(622, 450);
            this.basePanel.TabIndex = 1;
            // 
            // baseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "baseForm";
            this.Text = "Design Suites";
            this.Load += new System.EventHandler(this.baseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHoteles;
        private System.Windows.Forms.Button eventos;
        private System.Windows.Forms.Button habitaciones;
        private System.Windows.Forms.Button suministros;
        private System.Windows.Forms.Button reservas;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.ComboBox lstHotel;
    }
}

