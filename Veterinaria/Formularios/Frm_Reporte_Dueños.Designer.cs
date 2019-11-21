namespace Veterinaria.Formularios
{
    partial class Frm_Reporte_Dueños
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datosdueñosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datos_dueños = new Veterinaria.Datos.datos_dueños();
            this.datos_perros = new Veterinaria.Datos.datos_perros();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.datosdueñosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_dueños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_perros)).BeginInit();
            this.SuspendLayout();
            // 
            // datosdueñosBindingSource
            // 
            this.datosdueñosBindingSource.DataSource = this.datos_dueños;
            this.datosdueñosBindingSource.Position = 0;
            // 
            // datos_dueños
            // 
            this.datos_dueños.DataSetName = "datos_dueños";
            this.datos_dueños.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datos_perros
            // 
            this.datos_perros.DataSetName = "datos_perros";
            this.datos_perros.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.datosdueñosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Informes.informe_dueños.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // Frm_Reporte_Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Dueños";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Reporte_Dueños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosdueñosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_dueños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_perros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Datos.datos_perros datos_perros;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource datosdueñosBindingSource;
        private Datos.datos_dueños datos_dueños;
    }
}