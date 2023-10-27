namespace sistemaHoteles
{
    partial class eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eventos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnState = new System.Windows.Forms.Button();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.openFile = new System.Windows.Forms.Button();
            this.select2 = new System.Windows.Forms.Button();
            this.select1 = new System.Windows.Forms.Button();
            this.imgEvento = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtxtDesc = new System.Windows.Forms.TextBox();
            this.openFileButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numPrecio = new System.Windows.Forms.NumericUpDown();
            this.submitEvento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEvento)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnState);
            this.panel1.Controls.Add(this.lstEventos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 450);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtEvento);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 354);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 46);
            this.panel4.TabIndex = 5;
            // 
            // txtEvento
            // 
            this.txtEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvento.Location = new System.Drawing.Point(42, 0);
            this.txtEvento.MaxLength = 50;
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(108, 44);
            this.txtEvento.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Gray;
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnState.FlatAppearance.BorderSize = 0;
            this.btnState.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnState.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnState.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnState.Location = new System.Drawing.Point(0, 400);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(150, 50);
            this.btnState.TabIndex = 3;
            this.btnState.Text = "Modificar";
            this.btnState.UseVisualStyleBackColor = false;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEventos.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEventos.ForeColor = System.Drawing.SystemColors.Window;
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.ItemHeight = 31;
            this.lstEventos.Location = new System.Drawing.Point(0, 0);
            this.lstEventos.Margin = new System.Windows.Forms.Padding(0);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(150, 450);
            this.lstEventos.TabIndex = 1;
            this.lstEventos.Click += new System.EventHandler(this.lstEventos_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(650, 400);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.openFile, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.select2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.select1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.imgEvento, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(325, 400);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.DarkGray;
            this.openFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openFile.FlatAppearance.BorderSize = 0;
            this.openFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.openFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFile.ForeColor = System.Drawing.Color.Black;
            this.openFile.Location = new System.Drawing.Point(48, 340);
            this.openFile.Margin = new System.Windows.Forms.Padding(0);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(227, 60);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Archivo";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // select2
            // 
            this.select2.BackColor = System.Drawing.Color.DarkGray;
            this.select2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select2.BackgroundImage")));
            this.select2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select2.FlatAppearance.BorderSize = 0;
            this.select2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.select2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.select2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select2.Location = new System.Drawing.Point(275, 340);
            this.select2.Margin = new System.Windows.Forms.Padding(0);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(50, 60);
            this.select2.TabIndex = 3;
            this.select2.UseVisualStyleBackColor = false;
            this.select2.Click += new System.EventHandler(this.select2_Click);
            // 
            // select1
            // 
            this.select1.BackColor = System.Drawing.Color.DarkGray;
            this.select1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("select1.BackgroundImage")));
            this.select1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.select1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.select1.FlatAppearance.BorderSize = 0;
            this.select1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.select1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.select1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select1.Location = new System.Drawing.Point(0, 340);
            this.select1.Margin = new System.Windows.Forms.Padding(0);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(48, 60);
            this.select1.TabIndex = 2;
            this.select1.UseVisualStyleBackColor = false;
            this.select1.Click += new System.EventHandler(this.select1_Click);
            // 
            // imgEvento
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.imgEvento, 3);
            this.imgEvento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgEvento.Image = ((System.Drawing.Image)(resources.GetObject("imgEvento.Image")));
            this.imgEvento.Location = new System.Drawing.Point(3, 3);
            this.imgEvento.Name = "imgEvento";
            this.imgEvento.Size = new System.Drawing.Size(319, 334);
            this.imgEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEvento.TabIndex = 1;
            this.imgEvento.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.txtNombre);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtBaja);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtAlta);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.numPrecio);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(328, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 394);
            this.panel5.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(15, 51);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 28);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.Text = "...";
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 34);
            this.label2.TabIndex = 17;
            this.label2.Text = "Evento";
            // 
            // txtBaja
            // 
            this.txtBaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.txtBaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaja.ForeColor = System.Drawing.Color.White;
            this.txtBaja.Location = new System.Drawing.Point(11, 487);
            this.txtBaja.Name = "txtBaja";
            this.txtBaja.ReadOnly = true;
            this.txtBaja.Size = new System.Drawing.Size(279, 28);
            this.txtBaja.TabIndex = 16;
            this.txtBaja.Text = "...";
            this.txtBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Baja";
            // 
            // txtAlta
            // 
            this.txtAlta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.txtAlta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlta.ForeColor = System.Drawing.Color.White;
            this.txtAlta.Location = new System.Drawing.Point(11, 403);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.ReadOnly = true;
            this.txtAlta.Size = new System.Drawing.Size(279, 28);
            this.txtAlta.TabIndex = 14;
            this.txtAlta.Text = "...";
            this.txtAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(120, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 34);
            this.label6.TabIndex = 11;
            this.label6.Text = "Alta";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.rtxtDesc);
            this.panel6.Controls.Add(this.openFileButton);
            this.panel6.Location = new System.Drawing.Point(27, 138);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(260, 100);
            this.panel6.TabIndex = 10;
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDesc.Location = new System.Drawing.Point(42, 0);
            this.rtxtDesc.Multiline = true;
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(218, 100);
            this.rtxtDesc.TabIndex = 6;
            // 
            // openFileButton
            // 
            this.openFileButton.BackColor = System.Drawing.Color.Gray;
            this.openFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFileButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.openFileButton.FlatAppearance.BorderSize = 0;
            this.openFileButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.openFileButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.openFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileButton.Location = new System.Drawing.Point(0, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(42, 100);
            this.openFileButton.TabIndex = 5;
            this.openFileButton.Text = "+";
            this.openFileButton.UseVisualStyleBackColor = false;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(107, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 34);
            this.label7.TabIndex = 6;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(81)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(77, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 34);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descripción";
            // 
            // numPrecio
            // 
            this.numPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numPrecio.DecimalPlaces = 3;
            this.numPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPrecio.Location = new System.Drawing.Point(111, 304);
            this.numPrecio.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numPrecio.Name = "numPrecio";
            this.numPrecio.Size = new System.Drawing.Size(86, 29);
            this.numPrecio.TabIndex = 7;
            // 
            // submitEvento
            // 
            this.submitEvento.BackColor = System.Drawing.Color.Black;
            this.submitEvento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submitEvento.FlatAppearance.BorderSize = 0;
            this.submitEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.submitEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.submitEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitEvento.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitEvento.ForeColor = System.Drawing.Color.White;
            this.submitEvento.Location = new System.Drawing.Point(150, 400);
            this.submitEvento.Name = "submitEvento";
            this.submitEvento.Size = new System.Drawing.Size(650, 50);
            this.submitEvento.TabIndex = 19;
            this.submitEvento.Text = "Guardar";
            this.submitEvento.UseVisualStyleBackColor = false;
            this.submitEvento.Click += new System.EventHandler(this.submitEvento_Click);
            // 
            // eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.submitEvento);
            this.Controls.Add(this.panel1);
            this.Name = "eventos";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEvento)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.ListBox lstEventos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button select2;
        private System.Windows.Forms.Button select1;
        private System.Windows.Forms.PictureBox imgEvento;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox rtxtDesc;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numPrecio;
        private System.Windows.Forms.Button submitEvento;
    }
}