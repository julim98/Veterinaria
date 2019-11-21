namespace Veterinaria.Vista
{
    partial class Frm_ABM_Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Sucursales));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Cmb_Supervisor_Suplente = new System.Windows.Forms.ComboBox();
            this.Cmb_Supervisor = new System.Windows.Forms.ComboBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Pnl_Barra_Superior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.Btn_Minimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.Pnl_Barra_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Cmb_Supervisor_Suplente);
            this.panel2.Controls.Add(this.Cmb_Supervisor);
            this.panel2.Controls.Add(this.Txt_Nombre);
            this.panel2.Controls.Add(this.Btn_Cancelar);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 186);
            this.panel2.TabIndex = 48;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 52);
            this.button1.TabIndex = 59;
            this.button1.Text = "Nuevo Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmb_Supervisor_Suplente
            // 
            this.Cmb_Supervisor_Suplente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Supervisor_Suplente.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Supervisor_Suplente.FormattingEnabled = true;
            this.Cmb_Supervisor_Suplente.Location = new System.Drawing.Point(168, 79);
            this.Cmb_Supervisor_Suplente.Name = "Cmb_Supervisor_Suplente";
            this.Cmb_Supervisor_Suplente.Size = new System.Drawing.Size(206, 23);
            this.Cmb_Supervisor_Suplente.TabIndex = 58;
            this.Cmb_Supervisor_Suplente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Cmb_Supervisor
            // 
            this.Cmb_Supervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Supervisor.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Supervisor.FormattingEnabled = true;
            this.Cmb_Supervisor.Location = new System.Drawing.Point(168, 50);
            this.Cmb_Supervisor.Name = "Cmb_Supervisor";
            this.Cmb_Supervisor.Size = new System.Drawing.Size(206, 23);
            this.Cmb_Supervisor.TabIndex = 57;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nombre.Location = new System.Drawing.Point(168, 21);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(206, 23);
            this.Txt_Nombre.TabIndex = 56;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(274, 108);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 50);
            this.Btn_Cancelar.TabIndex = 55;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(168, 108);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 50);
            this.Btn_Guardar.TabIndex = 54;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(150, 15);
            this.label19.TabIndex = 53;
            this.label19.Text = "Supervisor Suplente:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(98, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 15);
            this.label20.TabIndex = 52;
            this.label20.Text = "Nombre:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(76, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "Supervisor:";
            // 
            // Pnl_Barra_Superior
            // 
            this.Pnl_Barra_Superior.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Pnl_Barra_Superior.Controls.Add(this.pictureBox1);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Cerrar);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Minimizar);
            this.Pnl_Barra_Superior.Controls.Add(this.label2);
            this.Pnl_Barra_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Barra_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Barra_Superior.Name = "Pnl_Barra_Superior";
            this.Pnl_Barra_Superior.Size = new System.Drawing.Size(517, 30);
            this.Pnl_Barra_Superior.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(487, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Cerrar.TabIndex = 27;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(457, 0);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Minimizar.TabIndex = 26;
            this.Btn_Minimizar.UseVisualStyleBackColor = true;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Administrar Sucursales";
            // 
            // Frm_ABM_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 216);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl_Barra_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Sucursales";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Pnl_Barra_Superior.ResumeLayout(false);
            this.Pnl_Barra_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Cmb_Supervisor;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel Pnl_Barra_Superior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Button Btn_Minimizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Supervisor_Suplente;
        private System.Windows.Forms.Button button1;
    }
}