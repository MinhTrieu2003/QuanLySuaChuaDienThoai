namespace QLDVSC
{
    partial class UcBaoCao
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox comboBoxRevenueFilter;
        private System.Windows.Forms.Label labelPieChartTitle;
        private System.Windows.Forms.Label labelPieChartLegend;
        private System.Windows.Forms.Label labelCartesianChartTitle;
        private System.Windows.Forms.Label labelCartesianChartLegend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.comboBoxRevenueFilter = new System.Windows.Forms.ComboBox();
            this.labelPieChartTitle = new System.Windows.Forms.Label();
            this.labelPieChartLegend = new System.Windows.Forms.Label();
            this.labelCartesianChartTitle = new System.Windows.Forms.Label();
            this.labelCartesianChartLegend = new System.Windows.Forms.Label();

            // TabControl
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;

            // TabPage1 (Báo cáo dịch vụ)
            this.tabPage1.Controls.Add(this.labelPieChartTitle);
            this.tabPage1.Controls.Add(this.labelPieChartLegend);
            this.tabPage1.Controls.Add(this.pieChart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;

            // TabPage2 (Báo cáo doanh thu)
            this.tabPage2.Controls.Add(this.labelCartesianChartTitle);
            this.tabPage2.Controls.Add(this.labelCartesianChartLegend);
            this.tabPage2.Controls.Add(this.comboBoxRevenueFilter);
            this.tabPage2.Controls.Add(this.cartesianChart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo doanh thu";
            this.tabPage2.UseVisualStyleBackColor = true;

            // PieChart1
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.None;
            this.pieChart1.Location = new System.Drawing.Point(10, 80);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(760, 330);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";

            // CartesianChart1
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.None;
            this.cartesianChart1.Location = new System.Drawing.Point(10, 80);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(760, 330);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";

            // ComboBoxRevenueFilter
            this.comboBoxRevenueFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRevenueFilter.FormattingEnabled = true;
            this.comboBoxRevenueFilter.Items.AddRange(new object[] { "By Month", "By Quarter" });
            this.comboBoxRevenueFilter.Location = new System.Drawing.Point(10, 10);
            this.comboBoxRevenueFilter.Name = "comboBoxRevenueFilter";
            this.comboBoxRevenueFilter.Size = new System.Drawing.Size(200, 25);
            this.comboBoxRevenueFilter.TabIndex = 0;
            this.comboBoxRevenueFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxRevenueFilter_SelectedIndexChanged);

            // LabelPieChartTitle
            this.labelPieChartTitle.AutoSize = true;
            this.labelPieChartTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelPieChartTitle.Location = new System.Drawing.Point(10, 10);
            this.labelPieChartTitle.Name = "labelPieChartTitle";
            this.labelPieChartTitle.Text = "Các dịch vụ được sử dụng nhiều nhất";

            // LabelPieChartLegend
            this.labelPieChartLegend.AutoSize = true;
            this.labelPieChartLegend.Font = new System.Drawing.Font("Arial", 10F);
            this.labelPieChartLegend.Location = new System.Drawing.Point(10, 40);
            this.labelPieChartLegend.Name = "labelPieChartLegend";
            this.labelPieChartLegend.Text = "Mỗi phần biểu đồ biểu diễn tần suất sử dụng một dịch vụ.";

            // LabelCartesianChartTitle
            this.labelCartesianChartTitle.AutoSize = true;
            this.labelCartesianChartTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelCartesianChartTitle.Location = new System.Drawing.Point(10, 50);
            this.labelCartesianChartTitle.Name = "labelCartesianChartTitle";
            this.labelCartesianChartTitle.Text = "Doanh thu theo thời gian";

            // LabelCartesianChartLegend
            this.labelCartesianChartLegend.AutoSize = true;
            this.labelCartesianChartLegend.Font = new System.Drawing.Font("Arial", 10F);
            this.labelCartesianChartLegend.Location = new System.Drawing.Point(10, 80);
            this.labelCartesianChartLegend.Name = "labelCartesianChartLegend";
            this.labelCartesianChartLegend.Text = "Biểu đồ thể hiện doanh thu theo tháng hoặc quý.";

            // UcBaoCao
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UcBaoCao";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.UcBaoCao_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
