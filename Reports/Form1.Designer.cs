namespace Reports
{
    partial class Form1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.northwndDataSet = new Reports.northwndDataSet();
            this.Customer_and_Suppliers_by_CityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Customer_and_Suppliers_by_CityTableAdapter = new Reports.northwndDataSetTableAdapters.Customer_and_Suppliers_by_CityTableAdapter();
            this.Order_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Order_DetailsTableAdapter = new Reports.northwndDataSetTableAdapters.Order_DetailsTableAdapter();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersTableAdapter = new Reports.northwndDataSetTableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_and_Suppliers_by_CityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsOrders";
            reportDataSource1.Value = this.Order_DetailsBindingSource;
            reportDataSource2.Name = "dsOrd";
            reportDataSource2.Value = this.OrdersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.rptOrders.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(646, 354);
            this.reportViewer1.TabIndex = 0;
            // 
            // northwndDataSet
            // 
            this.northwndDataSet.DataSetName = "northwndDataSet";
            this.northwndDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Customer_and_Suppliers_by_CityBindingSource
            // 
            this.Customer_and_Suppliers_by_CityBindingSource.DataMember = "Customer and Suppliers by City";
            this.Customer_and_Suppliers_by_CityBindingSource.DataSource = this.northwndDataSet;
            // 
            // Customer_and_Suppliers_by_CityTableAdapter
            // 
            this.Customer_and_Suppliers_by_CityTableAdapter.ClearBeforeFill = true;
            // 
            // Order_DetailsBindingSource
            // 
            this.Order_DetailsBindingSource.DataMember = "Order Details";
            this.Order_DetailsBindingSource.DataSource = this.northwndDataSet;
            // 
            // Order_DetailsTableAdapter
            // 
            this.Order_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.northwndDataSet;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.northwndDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_and_Suppliers_by_CityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Customer_and_Suppliers_by_CityBindingSource;
        private northwndDataSet northwndDataSet;
        private northwndDataSetTableAdapters.Customer_and_Suppliers_by_CityTableAdapter Customer_and_Suppliers_by_CityTableAdapter;
        private System.Windows.Forms.BindingSource Order_DetailsBindingSource;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private northwndDataSetTableAdapters.Order_DetailsTableAdapter Order_DetailsTableAdapter;
        private northwndDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
    }
}