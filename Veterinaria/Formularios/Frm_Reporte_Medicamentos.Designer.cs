namespace Veterinaria.Formularios
{
    partial class Frm_Reporte_Medicamentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.datos_medicamentos = new Veterinaria.datoss.datos_medicamentos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosmedicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datos_medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosmedicamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datos_medicamentos
            // 
            this.datos_medicamentos.DataSetName = "datos_medicamentos";
            this.datos_medicamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.datosmedicamentosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Veterinaria.Informess.informe_medicamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosmedicamentosBindingSource
            // 
            this.datosmedicamentosBindingSource.DataSource = this.datos_medicamentos;
            this.datosmedicamentosBindingSource.Position = 0;
            // 
            // Frm_Reporte_Medicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Reporte_Medicamentos";
            this.Text = "Frm_Reporte_Medicamentos";
            this.Load += new System.EventHandler(this.Frm_Reporte_Medicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos_medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosmedicamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datoss.datos_medicamentos datos_medicamentos;
        private System.Windows.Forms.BindingSource datosmedicamentosBindingSource;
    }
}