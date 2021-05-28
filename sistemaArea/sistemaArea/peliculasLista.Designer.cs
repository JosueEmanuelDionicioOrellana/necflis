namespace sistemaArea
{
    partial class peliculasLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(peliculasLista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cerrarListaPeliculas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.tablaPeliculas = new System.Windows.Forms.DataGridView();
            this.eliminarPelicula = new System.Windows.Forms.Button();
            this.modificarPelicula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.cerrarListaPeliculas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 100);
            this.panel1.TabIndex = 18;
            // 
            // cerrarListaPeliculas
            // 
            this.cerrarListaPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cerrarListaPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarListaPeliculas.FlatAppearance.BorderSize = 0;
            this.cerrarListaPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cerrarListaPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cerrarListaPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarListaPeliculas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarListaPeliculas.ForeColor = System.Drawing.Color.LightGray;
            this.cerrarListaPeliculas.Location = new System.Drawing.Point(509, 28);
            this.cerrarListaPeliculas.Name = "cerrarListaPeliculas";
            this.cerrarListaPeliculas.Size = new System.Drawing.Size(105, 42);
            this.cerrarListaPeliculas.TabIndex = 27;
            this.cerrarListaPeliculas.Text = "Cerrar";
            this.cerrarListaPeliculas.UseVisualStyleBackColor = false;
            this.cerrarListaPeliculas.Click += new System.EventHandler(this.cerrarListaPeliculas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(225, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de peliculas";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.ErrorImage = null;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(764, 12);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(24, 25);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btncerrar.TabIndex = 7;
            this.btncerrar.TabStop = false;
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.ErrorImage = null;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(734, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(24, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnminimizar.TabIndex = 8;
            this.btnminimizar.TabStop = false;
            // 
            // tablaPeliculas
            // 
            this.tablaPeliculas.BackgroundColor = System.Drawing.Color.Maroon;
            this.tablaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPeliculas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaPeliculas.Location = new System.Drawing.Point(42, 154);
            this.tablaPeliculas.Name = "tablaPeliculas";
            this.tablaPeliculas.Size = new System.Drawing.Size(540, 170);
            this.tablaPeliculas.TabIndex = 19;
            
            // 
            // eliminarPelicula
            // 
            this.eliminarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.eliminarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eliminarPelicula.FlatAppearance.BorderSize = 0;
            this.eliminarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.eliminarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eliminarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarPelicula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.eliminarPelicula.Location = new System.Drawing.Point(362, 366);
            this.eliminarPelicula.Name = "eliminarPelicula";
            this.eliminarPelicula.Size = new System.Drawing.Size(201, 47);
            this.eliminarPelicula.TabIndex = 23;
            this.eliminarPelicula.Text = "Eliminar";
            this.eliminarPelicula.UseVisualStyleBackColor = false;
            this.eliminarPelicula.Click += new System.EventHandler(this.eliminarPelicula_Click);
            // 
            // modificarPelicula
            // 
            this.modificarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.modificarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarPelicula.FlatAppearance.BorderSize = 0;
            this.modificarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.modificarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarPelicula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.modificarPelicula.Location = new System.Drawing.Point(58, 366);
            this.modificarPelicula.Name = "modificarPelicula";
            this.modificarPelicula.Size = new System.Drawing.Size(201, 47);
            this.modificarPelicula.TabIndex = 24;
            this.modificarPelicula.Text = "Modificar";
            this.modificarPelicula.UseVisualStyleBackColor = false;
            this.modificarPelicula.Click += new System.EventHandler(this.modificarPelicula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "SOLO VISTA*";
            // 
            // peliculasLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificarPelicula);
            this.Controls.Add(this.eliminarPelicula);
            this.Controls.Add(this.tablaPeliculas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "peliculasLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.DataGridView tablaPeliculas;
        private System.Windows.Forms.Button eliminarPelicula;
        private System.Windows.Forms.Button modificarPelicula;
        private System.Windows.Forms.Button cerrarListaPeliculas;
        private System.Windows.Forms.Label label2;
    }
}