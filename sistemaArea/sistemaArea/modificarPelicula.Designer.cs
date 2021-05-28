namespace sistemaArea
{
    partial class modificarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarPelicula));
            this.sinopsisPeliculas = new System.Windows.Forms.TextBox();
            this.generoPeliculas = new System.Windows.Forms.TextBox();
            this.tipoPeliculas = new System.Windows.Forms.TextBox();
            this.registrarPelicula = new System.Windows.Forms.Button();
            this.cancelarPelicula = new System.Windows.Forms.Button();
            this.nombrePeliculas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.tablaPeliculas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sinopsisPeliculas
            // 
            this.sinopsisPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.sinopsisPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinopsisPeliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinopsisPeliculas.ForeColor = System.Drawing.Color.DimGray;
            this.sinopsisPeliculas.Location = new System.Drawing.Point(45, 388);
            this.sinopsisPeliculas.Name = "sinopsisPeliculas";
            this.sinopsisPeliculas.Size = new System.Drawing.Size(272, 27);
            this.sinopsisPeliculas.TabIndex = 35;
            this.sinopsisPeliculas.Text = "Sinopsis";
            this.sinopsisPeliculas.Enter += new System.EventHandler(this.sinopsisPeliculas_Enter);
            this.sinopsisPeliculas.Leave += new System.EventHandler(this.sinopsisPeliculas_Leave);
            // 
            // generoPeliculas
            // 
            this.generoPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.generoPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generoPeliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generoPeliculas.ForeColor = System.Drawing.Color.DimGray;
            this.generoPeliculas.Location = new System.Drawing.Point(45, 355);
            this.generoPeliculas.Name = "generoPeliculas";
            this.generoPeliculas.Size = new System.Drawing.Size(272, 27);
            this.generoPeliculas.TabIndex = 34;
            this.generoPeliculas.Text = "Genero";
            this.generoPeliculas.Enter += new System.EventHandler(this.generoPeliculas_Enter);
            this.generoPeliculas.Leave += new System.EventHandler(this.generoPeliculas_Leave);
            // 
            // tipoPeliculas
            // 
            this.tipoPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.tipoPeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoPeliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPeliculas.ForeColor = System.Drawing.Color.DimGray;
            this.tipoPeliculas.Location = new System.Drawing.Point(45, 322);
            this.tipoPeliculas.Name = "tipoPeliculas";
            this.tipoPeliculas.Size = new System.Drawing.Size(272, 27);
            this.tipoPeliculas.TabIndex = 33;
            this.tipoPeliculas.Text = "Tipo";
            this.tipoPeliculas.Enter += new System.EventHandler(this.tipoPeliculas_Enter);
            this.tipoPeliculas.Leave += new System.EventHandler(this.tipoPeliculas_Leave);
            // 
            // registrarPelicula
            // 
            this.registrarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registrarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrarPelicula.FlatAppearance.BorderSize = 0;
            this.registrarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.registrarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registrarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarPelicula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.registrarPelicula.Location = new System.Drawing.Point(69, 437);
            this.registrarPelicula.Name = "registrarPelicula";
            this.registrarPelicula.Size = new System.Drawing.Size(201, 47);
            this.registrarPelicula.TabIndex = 32;
            this.registrarPelicula.Text = "Modificar";
            this.registrarPelicula.UseVisualStyleBackColor = false;
            this.registrarPelicula.Click += new System.EventHandler(this.registrarPelicula_Click);
            // 
            // cancelarPelicula
            // 
            this.cancelarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarPelicula.FlatAppearance.BorderSize = 0;
            this.cancelarPelicula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelarPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarPelicula.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.cancelarPelicula.Location = new System.Drawing.Point(384, 437);
            this.cancelarPelicula.Name = "cancelarPelicula";
            this.cancelarPelicula.Size = new System.Drawing.Size(201, 47);
            this.cancelarPelicula.TabIndex = 31;
            this.cancelarPelicula.Text = "Terminar";
            this.cancelarPelicula.UseVisualStyleBackColor = false;
            this.cancelarPelicula.Click += new System.EventHandler(this.cancelarPelicula_Click);
            // 
            // nombrePeliculas
            // 
            this.nombrePeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.nombrePeliculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombrePeliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePeliculas.ForeColor = System.Drawing.Color.DimGray;
            this.nombrePeliculas.Location = new System.Drawing.Point(45, 287);
            this.nombrePeliculas.Name = "nombrePeliculas";
            this.nombrePeliculas.Size = new System.Drawing.Size(272, 27);
            this.nombrePeliculas.TabIndex = 29;
            this.nombrePeliculas.Text = "Nombre";
            this.nombrePeliculas.Enter += new System.EventHandler(this.nombrePeliculas_Enter);
            this.nombrePeliculas.Leave += new System.EventHandler(this.nombrePeliculas_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 100);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(187, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 36);
            this.label2.TabIndex = 10;
            this.label2.Text = "Modificar Peliculas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 1;
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
            this.tablaPeliculas.Location = new System.Drawing.Point(45, 115);
            this.tablaPeliculas.Name = "tablaPeliculas";
            this.tablaPeliculas.Size = new System.Drawing.Size(540, 166);
            this.tablaPeliculas.TabIndex = 42;
            this.tablaPeliculas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaPeliculas_RowHeaderMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(384, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // modificarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(650, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaPeliculas);
            this.Controls.Add(this.sinopsisPeliculas);
            this.Controls.Add(this.generoPeliculas);
            this.Controls.Add(this.tipoPeliculas);
            this.Controls.Add(this.registrarPelicula);
            this.Controls.Add(this.cancelarPelicula);
            this.Controls.Add(this.nombrePeliculas);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarPelicula";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sinopsisPeliculas;
        private System.Windows.Forms.TextBox generoPeliculas;
        private System.Windows.Forms.TextBox tipoPeliculas;
        private System.Windows.Forms.Button registrarPelicula;
        private System.Windows.Forms.Button cancelarPelicula;
        private System.Windows.Forms.TextBox nombrePeliculas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.DataGridView tablaPeliculas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}