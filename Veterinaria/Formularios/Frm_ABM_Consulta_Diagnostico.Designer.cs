namespace Veterinaria.Formularios
{
    partial class Frm_ABM_Consulta_Diagnostico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Consulta_Diagnostico));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_diagnosticos = new System.Windows.Forms.DataGridView();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Pnl_Barra_Superior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id_diagnosticos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_diagnosticos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diagnosticos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_diagnosticos)).BeginInit();
            this.Pnl_Barra_Superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.tbl_diagnosticos);
            this.panel2.Controls.Add(this.Btn_Cancelar);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 340);
            this.panel2.TabIndex = 46;
            // 
            // tbl_diagnosticos
            // 
            this.tbl_diagnosticos.AllowUserToAddRows = false;
            this.tbl_diagnosticos.AllowUserToDeleteRows = false;
            this.tbl_diagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_diagnosticos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_diagnosticos,
            this.chk_diagnosticos,
            this.diagnosticos});
            this.tbl_diagnosticos.Location = new System.Drawing.Point(12, 22);
            this.tbl_diagnosticos.Name = "tbl_diagnosticos";
            this.tbl_diagnosticos.Size = new System.Drawing.Size(345, 235);
            this.tbl_diagnosticos.TabIndex = 52;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cancelar.Image")));
            this.Btn_Cancelar.Location = new System.Drawing.Point(258, 278);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(100, 50);
            this.Btn_Cancelar.TabIndex = 46;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.Location = new System.Drawing.Point(152, 278);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(100, 50);
            this.Btn_Guardar.TabIndex = 45;
            this.Btn_Guardar.Text = "Aceptar";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Pnl_Barra_Superior
            // 
            this.Pnl_Barra_Superior.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Pnl_Barra_Superior.Controls.Add(this.pictureBox1);
            this.Pnl_Barra_Superior.Controls.Add(this.Btn_Cerrar);
            this.Pnl_Barra_Superior.Controls.Add(this.label2);
            this.Pnl_Barra_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Barra_Superior.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Barra_Superior.Name = "Pnl_Barra_Superior";
            this.Pnl_Barra_Superior.Size = new System.Drawing.Size(370, 30);
            this.Pnl_Barra_Superior.TabIndex = 45;
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
            this.Btn_Cerrar.Location = new System.Drawing.Point(340, 0);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_Cerrar.TabIndex = 27;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Modificar Diagnosticos";
            // 
            // id_diagnosticos
            // 
            this.id_diagnosticos.HeaderText = "ID_Diagnosticos";
            this.id_diagnosticos.Name = "id_diagnosticos";
            this.id_diagnosticos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_diagnosticos.Visible = false;
            // 
            // chk_diagnosticos
            // 
            this.chk_diagnosticos.HeaderText = "";
            this.chk_diagnosticos.Name = "chk_diagnosticos";
            this.chk_diagnosticos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chk_diagnosticos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk_diagnosticos.Width = 50;
            // 
            // diagnosticos
            // 
            this.diagnosticos.HeaderText = "Diagnosticos";
            this.diagnosticos.Name = "diagnosticos";
            this.diagnosticos.ReadOnly = true;
            this.diagnosticos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.diagnosticos.Width = 300;
            // 
            // Frm_ABM_Consulta_Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Pnl_Barra_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_Consulta_Diagnostico";
            this.Text = "Frm_ABM_Consulta_Diagnostico";
            this.Load += new System.EventHandler(this.Frm_ABM_Consulta_Diagnostico_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_diagnosticos)).EndInit();
            this.Pnl_Barra_Superior.ResumeLayout(false);
            this.Pnl_Barra_Superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Panel Pnl_Barra_Superior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tbl_diagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_diagnosticos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk_diagnosticos;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticos;
    }
}