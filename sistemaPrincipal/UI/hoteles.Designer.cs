﻿
namespace sistemaPrincipal
{
    partial class hoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hoteles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEstructura = new System.Windows.Forms.TableLayoutPanel();
            this.backBoton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedorHoteles = new System.Windows.Forms.DataGridView();
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
            this.panelEstructura.Controls.Add(this.button1, 2, 0);
            this.panelEstructura.Controls.Add(this.label1, 1, 0);
            this.panelEstructura.Controls.Add(this.contenedorHoteles, 1, 1);
            this.panelEstructura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstructura.Location = new System.Drawing.Point(0, 0);
            this.panelEstructura.Name = "panelEstructura";
            this.panelEstructura.RowCount = 2;
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelEstructura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelEstructura.Size = new System.Drawing.Size(800, 380);
            this.panelEstructura.TabIndex = 0;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(643, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 70);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addHotel);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTA DE HOTELES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorHoteles
            // 
            this.contenedorHoteles.AllowUserToAddRows = false;
            this.contenedorHoteles.AllowUserToDeleteRows = false;
            this.contenedorHoteles.AllowUserToResizeRows = false;
            this.contenedorHoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contenedorHoteles.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.contenedorHoteles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contenedorHoteles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contenedorHoteles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contenedorHoteles.ColumnHeadersHeight = 50;
            this.contenedorHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.contenedorHoteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorHoteles.EnableHeadersVisualStyles = false;
            this.contenedorHoteles.GridColor = System.Drawing.Color.CornflowerBlue;
            this.contenedorHoteles.Location = new System.Drawing.Point(163, 79);
            this.contenedorHoteles.Name = "contenedorHoteles";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contenedorHoteles.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contenedorHoteles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.contenedorHoteles.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.contenedorHoteles.RowTemplate.Height = 30;
            this.contenedorHoteles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.contenedorHoteles.Size = new System.Drawing.Size(474, 298);
            this.contenedorHoteles.TabIndex = 4;
            // 
            // hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.panelEstructura);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hoteles";
            this.Text = "Form1";
            this.panelEstructura.ResumeLayout(false);
            this.panelEstructura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenedorHoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelEstructura;
        private System.Windows.Forms.Button backBoton;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView contenedorHoteles;
    }
}