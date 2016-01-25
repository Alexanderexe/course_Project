namespace Finaly
{
    partial class Main_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Fhighvalue = new System.Windows.Forms.TextBox();
            this.tb_Flowvalue = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.btn_sort_bonus = new System.Windows.Forms.Button();
            this.btn_sort_status = new System.Windows.Forms.Button();
            this.dgv_deals_of_card = new System.Windows.Forms.DataGridView();
            this.dgv_cardinfo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_filter_location = new System.Windows.Forms.TextBox();
            this.btn_filter_station = new System.Windows.Forms.Button();
            this.dgv_deals_of_station = new System.Windows.Forms.DataGridView();
            this.dgv_stationinfo = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_status_ratio = new System.Windows.Forms.Button();
            this.btn_best_product = new System.Windows.Forms.Button();
            this.report_clients = new System.Windows.Forms.Button();
            this.report_stations = new System.Windows.Forms.Button();
            this.btn_best_client = new System.Windows.Forms.Button();
            this.bt_avg_check = new System.Windows.Forms.Button();
            this.dgv_statistic = new System.Windows.Forms.DataGridView();
            this.btn_stat_turnover = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.cb_admin = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deals_of_card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardinfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deals_of_station)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stationinfo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistic)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1195, 529);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_Fhighvalue);
            this.tabPage1.Controls.Add(this.tb_Flowvalue);
            this.tabPage1.Controls.Add(this.cb_filter);
            this.tabPage1.Controls.Add(this.btn_sort_bonus);
            this.tabPage1.Controls.Add(this.btn_sort_status);
            this.tabPage1.Controls.Add(this.dgv_deals_of_card);
            this.tabPage1.Controls.Add(this.dgv_cardinfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1187, 503);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "card info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "between";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "and";
            // 
            // tb_Fhighvalue
            // 
            this.tb_Fhighvalue.Location = new System.Drawing.Point(324, 203);
            this.tb_Fhighvalue.Name = "tb_Fhighvalue";
            this.tb_Fhighvalue.Size = new System.Drawing.Size(75, 20);
            this.tb_Fhighvalue.TabIndex = 6;
            // 
            // tb_Flowvalue
            // 
            this.tb_Flowvalue.Location = new System.Drawing.Point(326, 164);
            this.tb_Flowvalue.Name = "tb_Flowvalue";
            this.tb_Flowvalue.Size = new System.Drawing.Size(75, 20);
            this.tb_Flowvalue.TabIndex = 5;
            // 
            // cb_filter
            // 
            this.cb_filter.AutoCompleteCustomSource.AddRange(new string[] {
            "gold",
            "silver",
            "start"});
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "gold",
            "silver",
            "start",
            "ALL"});
            this.cb_filter.Location = new System.Drawing.Point(326, 69);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(75, 21);
            this.cb_filter.TabIndex = 4;
            // 
            // btn_sort_bonus
            // 
            this.btn_sort_bonus.Location = new System.Drawing.Point(324, 96);
            this.btn_sort_bonus.Name = "btn_sort_bonus";
            this.btn_sort_bonus.Size = new System.Drawing.Size(76, 49);
            this.btn_sort_bonus.TabIndex = 3;
            this.btn_sort_bonus.Text = "filter by bonus";
            this.btn_sort_bonus.UseVisualStyleBackColor = true;
            this.btn_sort_bonus.Click += new System.EventHandler(this.btn_sort_bonus_Click);
            // 
            // btn_sort_status
            // 
            this.btn_sort_status.Location = new System.Drawing.Point(325, 6);
            this.btn_sort_status.Name = "btn_sort_status";
            this.btn_sort_status.Size = new System.Drawing.Size(76, 49);
            this.btn_sort_status.TabIndex = 2;
            this.btn_sort_status.Text = "filter by status";
            this.btn_sort_status.UseVisualStyleBackColor = true;
            this.btn_sort_status.Click += new System.EventHandler(this.btn_sort_status_Click);
            // 
            // dgv_deals_of_card
            // 
            this.dgv_deals_of_card.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_deals_of_card.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deals_of_card.Location = new System.Drawing.Point(407, 6);
            this.dgv_deals_of_card.Name = "dgv_deals_of_card";
            this.dgv_deals_of_card.Size = new System.Drawing.Size(772, 491);
            this.dgv_deals_of_card.TabIndex = 1;
            // 
            // dgv_cardinfo
            // 
            this.dgv_cardinfo.AllowUserToAddRows = false;
            this.dgv_cardinfo.AllowUserToDeleteRows = false;
            this.dgv_cardinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cardinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cardinfo.Location = new System.Drawing.Point(8, 6);
            this.dgv_cardinfo.Name = "dgv_cardinfo";
            this.dgv_cardinfo.ReadOnly = true;
            this.dgv_cardinfo.Size = new System.Drawing.Size(311, 491);
            this.dgv_cardinfo.TabIndex = 0;
            this.dgv_cardinfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cardinfo_RowHeaderMouseDoubleClick);
            this.dgv_cardinfo.SelectionChanged += new System.EventHandler(this.dgv_cardinfo_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_filter_location);
            this.tabPage2.Controls.Add(this.btn_filter_station);
            this.tabPage2.Controls.Add(this.dgv_deals_of_station);
            this.tabPage2.Controls.Add(this.dgv_stationinfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1187, 503);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "station info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_filter_location
            // 
            this.tb_filter_location.Location = new System.Drawing.Point(322, 61);
            this.tb_filter_location.Name = "tb_filter_location";
            this.tb_filter_location.Size = new System.Drawing.Size(76, 20);
            this.tb_filter_location.TabIndex = 4;
            // 
            // btn_filter_station
            // 
            this.btn_filter_station.Location = new System.Drawing.Point(322, 6);
            this.btn_filter_station.Name = "btn_filter_station";
            this.btn_filter_station.Size = new System.Drawing.Size(76, 49);
            this.btn_filter_station.TabIndex = 3;
            this.btn_filter_station.Text = "filter by status";
            this.btn_filter_station.UseVisualStyleBackColor = true;
            this.btn_filter_station.Click += new System.EventHandler(this.btn_filter_station_Click);
            // 
            // dgv_deals_of_station
            // 
            this.dgv_deals_of_station.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_deals_of_station.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deals_of_station.Location = new System.Drawing.Point(404, 6);
            this.dgv_deals_of_station.Name = "dgv_deals_of_station";
            this.dgv_deals_of_station.Size = new System.Drawing.Size(750, 491);
            this.dgv_deals_of_station.TabIndex = 2;
            // 
            // dgv_stationinfo
            // 
            this.dgv_stationinfo.AllowUserToAddRows = false;
            this.dgv_stationinfo.AllowUserToDeleteRows = false;
            this.dgv_stationinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_stationinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stationinfo.Location = new System.Drawing.Point(8, 6);
            this.dgv_stationinfo.Name = "dgv_stationinfo";
            this.dgv_stationinfo.ReadOnly = true;
            this.dgv_stationinfo.Size = new System.Drawing.Size(311, 491);
            this.dgv_stationinfo.TabIndex = 1;
            this.dgv_stationinfo.SelectionChanged += new System.EventHandler(this.dgv_stationinfo_SelectionChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.diagram);
            this.tabPage3.Controls.Add(this.btn_status_ratio);
            this.tabPage3.Controls.Add(this.btn_best_product);
            this.tabPage3.Controls.Add(this.report_clients);
            this.tabPage3.Controls.Add(this.report_stations);
            this.tabPage3.Controls.Add(this.btn_best_client);
            this.tabPage3.Controls.Add(this.bt_avg_check);
            this.tabPage3.Controls.Add(this.dgv_statistic);
            this.tabPage3.Controls.Add(this.btn_stat_turnover);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1187, 503);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "statistic";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.diagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.diagram.Legends.Add(legend1);
            this.diagram.Location = new System.Drawing.Point(518, 3);
            this.diagram.Name = "diagram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "station";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.diagram.Series.Add(series1);
            this.diagram.Size = new System.Drawing.Size(641, 493);
            this.diagram.TabIndex = 8;
            this.diagram.Text = "chart1";
            // 
            // btn_status_ratio
            // 
            this.btn_status_ratio.Location = new System.Drawing.Point(8, 473);
            this.btn_status_ratio.Name = "btn_status_ratio";
            this.btn_status_ratio.Size = new System.Drawing.Size(157, 23);
            this.btn_status_ratio.TabIndex = 7;
            this.btn_status_ratio.Text = "status ratio";
            this.btn_status_ratio.UseVisualStyleBackColor = true;
            this.btn_status_ratio.Click += new System.EventHandler(this.btn_status_ratio_Click);
            // 
            // btn_best_product
            // 
            this.btn_best_product.Location = new System.Drawing.Point(8, 444);
            this.btn_best_product.Name = "btn_best_product";
            this.btn_best_product.Size = new System.Drawing.Size(157, 23);
            this.btn_best_product.TabIndex = 6;
            this.btn_best_product.Text = "best product";
            this.btn_best_product.UseVisualStyleBackColor = true;
            this.btn_best_product.Click += new System.EventHandler(this.btn_best_product_Click);
            // 
            // report_clients
            // 
            this.report_clients.Location = new System.Drawing.Point(8, 415);
            this.report_clients.Name = "report_clients";
            this.report_clients.Size = new System.Drawing.Size(157, 23);
            this.report_clients.TabIndex = 5;
            this.report_clients.Text = "print client report";
            this.report_clients.UseVisualStyleBackColor = true;
            this.report_clients.Click += new System.EventHandler(this.report_clients_Click);
            // 
            // report_stations
            // 
            this.report_stations.Location = new System.Drawing.Point(8, 386);
            this.report_stations.Name = "report_stations";
            this.report_stations.Size = new System.Drawing.Size(157, 23);
            this.report_stations.TabIndex = 4;
            this.report_stations.Text = "print station report";
            this.report_stations.UseVisualStyleBackColor = true;
            this.report_stations.Click += new System.EventHandler(this.report_stations_Click);
            // 
            // btn_best_client
            // 
            this.btn_best_client.Location = new System.Drawing.Point(8, 357);
            this.btn_best_client.Name = "btn_best_client";
            this.btn_best_client.Size = new System.Drawing.Size(157, 23);
            this.btn_best_client.TabIndex = 3;
            this.btn_best_client.Text = "station best clients";
            this.btn_best_client.UseVisualStyleBackColor = true;
            this.btn_best_client.Click += new System.EventHandler(this.btn_best_client_Click);
            // 
            // bt_avg_check
            // 
            this.bt_avg_check.Location = new System.Drawing.Point(8, 328);
            this.bt_avg_check.Name = "bt_avg_check";
            this.bt_avg_check.Size = new System.Drawing.Size(157, 23);
            this.bt_avg_check.TabIndex = 2;
            this.bt_avg_check.Text = "station averege check";
            this.bt_avg_check.UseVisualStyleBackColor = true;
            this.bt_avg_check.Click += new System.EventHandler(this.bt_avg_check_Click);
            // 
            // dgv_statistic
            // 
            this.dgv_statistic.AllowUserToAddRows = false;
            this.dgv_statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_statistic.Location = new System.Drawing.Point(8, 3);
            this.dgv_statistic.Name = "dgv_statistic";
            this.dgv_statistic.Size = new System.Drawing.Size(494, 290);
            this.dgv_statistic.TabIndex = 1;
            // 
            // btn_stat_turnover
            // 
            this.btn_stat_turnover.Location = new System.Drawing.Point(8, 299);
            this.btn_stat_turnover.Name = "btn_stat_turnover";
            this.btn_stat_turnover.Size = new System.Drawing.Size(157, 23);
            this.btn_stat_turnover.TabIndex = 0;
            this.btn_stat_turnover.Text = "station turnover";
            this.btn_stat_turnover.UseVisualStyleBackColor = true;
            this.btn_stat_turnover.Click += new System.EventHandler(this.btn_stat_turnover_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_backup);
            this.tabPage4.Controls.Add(this.btn_admin);
            this.tabPage4.Controls.Add(this.cb_admin);
            this.tabPage4.Controls.Add(this.btn_edit);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.btn_add);
            this.tabPage4.Controls.Add(this.dgv_admin);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1187, 503);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "admin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_backup
            // 
            this.btn_backup.Location = new System.Drawing.Point(681, 8);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(94, 109);
            this.btn_backup.TabIndex = 12;
            this.btn_backup.Text = "backup database";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(781, 8);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(95, 109);
            this.btn_admin.TabIndex = 11;
            this.btn_admin.Text = "admin activate";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // cb_admin
            // 
            this.cb_admin.DisplayMember = "1";
            this.cb_admin.FormattingEnabled = true;
            this.cb_admin.Items.AddRange(new object[] {
            "cards",
            "stations",
            "deals",
            "product"});
            this.cb_admin.Location = new System.Drawing.Point(521, 8);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(121, 21);
            this.cb_admin.TabIndex = 10;
            this.cb_admin.Text = "cards";
            this.cb_admin.TextChanged += new System.EventHandler(this.cb_admin_TextChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(521, 64);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 24);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(521, 35);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(8, 8);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.Size = new System.Drawing.Size(507, 487);
            this.dgv_admin.TabIndex = 0;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_form";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deals_of_card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cardinfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deals_of_station)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stationinfo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_statistic)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_deals_of_card;
        private System.Windows.Forms.DataGridView dgv_cardinfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_deals_of_station;
        private System.Windows.Forms.DataGridView dgv_stationinfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_sort_bonus;
        private System.Windows.Forms.Button btn_sort_status;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Fhighvalue;
        private System.Windows.Forms.TextBox tb_Flowvalue;
        private System.Windows.Forms.TextBox tb_filter_location;
        private System.Windows.Forms.Button btn_filter_station;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.ComboBox cb_admin;
        private System.Windows.Forms.DataGridView dgv_statistic;
        private System.Windows.Forms.Button btn_stat_turnover;
        private System.Windows.Forms.DataVisualization.Charting.Chart diagram;
        private System.Windows.Forms.Button btn_status_ratio;
        private System.Windows.Forms.Button btn_best_product;
        private System.Windows.Forms.Button report_clients;
        private System.Windows.Forms.Button report_stations;
        private System.Windows.Forms.Button btn_best_client;
        private System.Windows.Forms.Button bt_avg_check;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_admin;
    }
}

