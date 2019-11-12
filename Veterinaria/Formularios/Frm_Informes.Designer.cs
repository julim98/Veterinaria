namespace Veterinaria.Formularios
{
    partial class Frm_Informes
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
            this.Btn_Empleados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Empleados.FlatAppearance.BorderSize = 2;
            this.Btn_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Empleados.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleados.Location = new System.Drawing.Point(12, 12);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Size = new System.Drawing.Size(360, 80);
            this.Btn_Empleados.TabIndex = 1;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.UseVisualStyleBackColor = false;
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(392, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(360, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Empleados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Empleados);
            this.Name = "Frm_Informes";
            this.Text = "Frm_Informes";
            this.Load += new System.EventHandler(this.Frm_Informes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Empleados;
        private System.Windows.Forms.Button button1;
    }
}