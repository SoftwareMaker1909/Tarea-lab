﻿namespace SistemaCitas
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btcitas = new System.Windows.Forms.Button();
            this.btconsultorios = new System.Windows.Forms.Button();
            this.btpisos = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btcitas);
            this.panel1.Controls.Add(this.btconsultorios);
            this.panel1.Controls.Add(this.btpisos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 624);
            this.panel1.TabIndex = 0;
            // 
            // btcitas
            // 
            this.btcitas.Location = new System.Drawing.Point(0, 332);
            this.btcitas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btcitas.Name = "btcitas";
            this.btcitas.Size = new System.Drawing.Size(296, 58);
            this.btcitas.TabIndex = 0;
            this.btcitas.Text = "Citas";
            this.btcitas.UseVisualStyleBackColor = true;
            this.btcitas.Click += new System.EventHandler(this.btcitas_Click);
            // 
            // btconsultorios
            // 
            this.btconsultorios.Location = new System.Drawing.Point(0, 219);
            this.btconsultorios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btconsultorios.Name = "btconsultorios";
            this.btconsultorios.Size = new System.Drawing.Size(296, 58);
            this.btconsultorios.TabIndex = 0;
            this.btconsultorios.Text = "Consultorios";
            this.btconsultorios.UseVisualStyleBackColor = true;
            this.btconsultorios.Click += new System.EventHandler(this.btconsultorios_Click);
            // 
            // btpisos
            // 
            this.btpisos.Location = new System.Drawing.Point(0, 114);
            this.btpisos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btpisos.Name = "btpisos";
            this.btpisos.Size = new System.Drawing.Size(296, 58);
            this.btpisos.TabIndex = 0;
            this.btpisos.Text = "Pisos";
            this.btpisos.UseVisualStyleBackColor = true;
            this.btpisos.Click += new System.EventHandler(this.btpisos_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.DarkGray;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(296, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1183, 624);
            this.container.TabIndex = 1;
            this.container.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 624);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcitas;
        private System.Windows.Forms.Button btconsultorios;
        private System.Windows.Forms.Button btpisos;
        private System.Windows.Forms.Panel container;
    }
}