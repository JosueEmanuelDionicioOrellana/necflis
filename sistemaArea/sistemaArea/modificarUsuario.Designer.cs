namespace sistemaArea
{
    partial class modificarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modificarUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.nombreUsuario = new System.Windows.Forms.TextBox();
            this.apellidoUsuario = new System.Windows.Forms.TextBox();
            this.correoUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contraseñaUsuario = new System.Windows.Forms.TextBox();
            this.ConfirmacionContraseña = new System.Windows.Forms.TextBox();
            this.TelefonoUsuario = new System.Windows.Forms.TextBox();
            this.modificarUsuarios = new System.Windows.Forms.Button();
            this.cancelarUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncerrar);
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 100);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(154, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Usuarios";
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
            // tablaUsuarios
            // 
            this.tablaUsuarios.BackgroundColor = System.Drawing.Color.Maroon;
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tablaUsuarios.Location = new System.Drawing.Point(0, 123);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(634, 107);
            this.tablaUsuarios.TabIndex = 43;
            this.tablaUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaUsuarios_RowHeaderMouseClick);
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.nombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.nombreUsuario.Location = new System.Drawing.Point(12, 236);
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.Size = new System.Drawing.Size(277, 27);
            this.nombreUsuario.TabIndex = 44;
            this.nombreUsuario.Text = "Nombre";
            this.nombreUsuario.Enter += new System.EventHandler(this.nombreUsuario_Enter);
            this.nombreUsuario.Leave += new System.EventHandler(this.nombreUsuario_Leave);
            // 
            // apellidoUsuario
            // 
            this.apellidoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.apellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apellidoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.apellidoUsuario.Location = new System.Drawing.Point(12, 269);
            this.apellidoUsuario.Name = "apellidoUsuario";
            this.apellidoUsuario.Size = new System.Drawing.Size(277, 27);
            this.apellidoUsuario.TabIndex = 45;
            this.apellidoUsuario.Text = "Apellido";
            this.apellidoUsuario.Enter += new System.EventHandler(this.apellidoUsuario_Enter);
            this.apellidoUsuario.Leave += new System.EventHandler(this.apellidoUsuario_Leave);
            // 
            // correoUsuario
            // 
            this.correoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.correoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.correoUsuario.Location = new System.Drawing.Point(12, 302);
            this.correoUsuario.Name = "correoUsuario";
            this.correoUsuario.Size = new System.Drawing.Size(155, 27);
            this.correoUsuario.TabIndex = 46;
            this.correoUsuario.Text = "Correo Electronico";
            this.correoUsuario.Enter += new System.EventHandler(this.correoUsuario_Enter);
            this.correoUsuario.Leave += new System.EventHandler(this.correoUsuario_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(173, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 47;
            this.label3.Text = "@gmail.com";
            // 
            // contraseñaUsuario
            // 
            this.contraseñaUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.contraseñaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contraseñaUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.contraseñaUsuario.Location = new System.Drawing.Point(12, 335);
            this.contraseñaUsuario.Name = "contraseñaUsuario";
            this.contraseñaUsuario.Size = new System.Drawing.Size(277, 27);
            this.contraseñaUsuario.TabIndex = 48;
            this.contraseñaUsuario.Text = "Contraseña";
            this.contraseñaUsuario.Enter += new System.EventHandler(this.contraseñaUsuario_Enter);
            this.contraseñaUsuario.Leave += new System.EventHandler(this.contraseñaUsuario_Leave);
            // 
            // ConfirmacionContraseña
            // 
            this.ConfirmacionContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ConfirmacionContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmacionContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmacionContraseña.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmacionContraseña.Location = new System.Drawing.Point(12, 368);
            this.ConfirmacionContraseña.Name = "ConfirmacionContraseña";
            this.ConfirmacionContraseña.Size = new System.Drawing.Size(277, 27);
            this.ConfirmacionContraseña.TabIndex = 49;
            this.ConfirmacionContraseña.Text = "Confirmacion de Contraseña";
            this.ConfirmacionContraseña.Enter += new System.EventHandler(this.ConfirmacionContraseña_Enter);
            this.ConfirmacionContraseña.Leave += new System.EventHandler(this.ConfirmacionContraseña_Leave);
            // 
            // TelefonoUsuario
            // 
            this.TelefonoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.TelefonoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonoUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TelefonoUsuario.Location = new System.Drawing.Point(12, 401);
            this.TelefonoUsuario.Name = "TelefonoUsuario";
            this.TelefonoUsuario.Size = new System.Drawing.Size(277, 27);
            this.TelefonoUsuario.TabIndex = 50;
            this.TelefonoUsuario.Text = "No. de Telefono";
            this.TelefonoUsuario.Enter += new System.EventHandler(this.TelefonoUsuario_Enter);
            this.TelefonoUsuario.Leave += new System.EventHandler(this.TelefonoUsuario_Leave);
            // 
            // modificarUsuarios
            // 
            this.modificarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.modificarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificarUsuarios.FlatAppearance.BorderSize = 0;
            this.modificarUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.modificarUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modificarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarUsuarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarios.ForeColor = System.Drawing.Color.LightGray;
            this.modificarUsuarios.Location = new System.Drawing.Point(59, 443);
            this.modificarUsuarios.Name = "modificarUsuarios";
            this.modificarUsuarios.Size = new System.Drawing.Size(201, 47);
            this.modificarUsuarios.TabIndex = 51;
            this.modificarUsuarios.Text = "Modificar";
            this.modificarUsuarios.UseVisualStyleBackColor = false;
            this.modificarUsuarios.Click += new System.EventHandler(this.modificarUsuarios_Click);
            // 
            // cancelarUsuario
            // 
            this.cancelarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cancelarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarUsuario.FlatAppearance.BorderSize = 0;
            this.cancelarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cancelarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelarUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.cancelarUsuario.Location = new System.Drawing.Point(339, 443);
            this.cancelarUsuario.Name = "cancelarUsuario";
            this.cancelarUsuario.Size = new System.Drawing.Size(201, 47);
            this.cancelarUsuario.TabIndex = 52;
            this.cancelarUsuario.Text = "Terminar";
            this.cancelarUsuario.UseVisualStyleBackColor = false;
            this.cancelarUsuario.Click += new System.EventHandler(this.cancelarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 245);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // modificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.ClientSize = new System.Drawing.Size(634, 502);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelarUsuario);
            this.Controls.Add(this.modificarUsuarios);
            this.Controls.Add(this.TelefonoUsuario);
            this.Controls.Add(this.ConfirmacionContraseña);
            this.Controls.Add(this.contraseñaUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.correoUsuario);
            this.Controls.Add(this.apellidoUsuario);
            this.Controls.Add(this.nombreUsuario);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificarUsuario";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private System.Windows.Forms.TextBox nombreUsuario;
        private System.Windows.Forms.TextBox apellidoUsuario;
        private System.Windows.Forms.TextBox correoUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contraseñaUsuario;
        private System.Windows.Forms.TextBox ConfirmacionContraseña;
        private System.Windows.Forms.TextBox TelefonoUsuario;
        private System.Windows.Forms.Button modificarUsuarios;
        private System.Windows.Forms.Button cancelarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}