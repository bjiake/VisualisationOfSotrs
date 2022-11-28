namespace Sorts {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBubble = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbShake = new System.Windows.Forms.CheckBox();
            this.cbFast = new System.Windows.Forms.CheckBox();
            this.cbBogo = new System.Windows.Forms.CheckBox();
            this.btDataAdd = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.chartBubble = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFast = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBogo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartInputs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartShake = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbVisual = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBubble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInputs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShake)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.value});
            this.dataGridView1.Location = new System.Drawing.Point(842, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(207, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // index
            // 
            this.index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.index.DataPropertyName = "int";
            this.index.HeaderText = "index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 57;
            // 
            // value
            // 
            this.value.DataPropertyName = "double";
            this.value.HeaderText = "value";
            this.value.Name = "value";
            this.value.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cbBubble
            // 
            this.cbBubble.AutoSize = true;
            this.cbBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBubble.Location = new System.Drawing.Point(12, 579);
            this.cbBubble.Name = "cbBubble";
            this.cbBubble.Size = new System.Drawing.Size(151, 28);
            this.cbBubble.TabIndex = 1;
            this.cbBubble.Text = "Пузырьковый";
            this.cbBubble.UseVisualStyleBackColor = true;
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInsert.Location = new System.Drawing.Point(12, 613);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(102, 28);
            this.cbInsert.TabIndex = 1;
            this.cbInsert.Text = "Вставки";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbShake
            // 
            this.cbShake.AutoSize = true;
            this.cbShake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShake.Location = new System.Drawing.Point(12, 647);
            this.cbShake.Name = "cbShake";
            this.cbShake.Size = new System.Drawing.Size(127, 28);
            this.cbShake.TabIndex = 1;
            this.cbShake.Text = "Шейкерная";
            this.cbShake.UseVisualStyleBackColor = true;
            // 
            // cbFast
            // 
            this.cbFast.AutoSize = true;
            this.cbFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFast.Location = new System.Drawing.Point(12, 545);
            this.cbFast.Name = "cbFast";
            this.cbFast.Size = new System.Drawing.Size(106, 28);
            this.cbFast.TabIndex = 1;
            this.cbFast.Text = "Быстрая";
            this.cbFast.UseVisualStyleBackColor = true;
            // 
            // cbBogo
            // 
            this.cbBogo.AutoSize = true;
            this.cbBogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBogo.Location = new System.Drawing.Point(12, 681);
            this.cbBogo.Name = "cbBogo";
            this.cbBogo.Size = new System.Drawing.Size(85, 28);
            this.cbBogo.TabIndex = 1;
            this.cbBogo.Text = "BOGO";
            this.cbBogo.UseVisualStyleBackColor = true;
            // 
            // btDataAdd
            // 
            this.btDataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDataAdd.Location = new System.Drawing.Point(842, 543);
            this.btDataAdd.Name = "btDataAdd";
            this.btDataAdd.Size = new System.Drawing.Size(207, 30);
            this.btDataAdd.TabIndex = 2;
            this.btDataAdd.Text = "Внести данные";
            this.btDataAdd.UseVisualStyleBackColor = true;
            this.btDataAdd.Click += new System.EventHandler(this.btDataAdd_Click);
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSort.Location = new System.Drawing.Point(371, 613);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(181, 30);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Начать сортировку";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // chartBubble
            // 
            chartArea1.Name = "ChartArea1";
            this.chartBubble.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartBubble.Legends.Add(legend1);
            this.chartBubble.Location = new System.Drawing.Point(12, 48);
            this.chartBubble.Name = "chartBubble";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartBubble.Series.Add(series1);
            this.chartBubble.Size = new System.Drawing.Size(334, 234);
            this.chartBubble.TabIndex = 3;
            this.chartBubble.Text = "Chart";
            title1.BackColor = System.Drawing.Color.White;
            title1.BackSecondaryColor = System.Drawing.Color.Black;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "Title";
            this.chartBubble.Titles.Add(title1);
            // 
            // chartFast
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFast.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFast.Legends.Add(legend2);
            this.chartFast.Location = new System.Drawing.Point(371, 48);
            this.chartFast.Name = "chartFast";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFast.Series.Add(series2);
            this.chartFast.Size = new System.Drawing.Size(334, 234);
            this.chartFast.TabIndex = 3;
            this.chartFast.Text = "Chart";
            title2.BackColor = System.Drawing.Color.White;
            title2.BackSecondaryColor = System.Drawing.Color.Black;
            title2.BorderColor = System.Drawing.Color.Black;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Title";
            title2.Text = "Title";
            this.chartFast.Titles.Add(title2);
            // 
            // chartBogo
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBogo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBogo.Legends.Add(legend3);
            this.chartBogo.Location = new System.Drawing.Point(711, 48);
            this.chartBogo.Name = "chartBogo";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBogo.Series.Add(series3);
            this.chartBogo.Size = new System.Drawing.Size(334, 234);
            this.chartBogo.TabIndex = 3;
            this.chartBogo.Text = "Chart";
            title3.BackColor = System.Drawing.Color.White;
            title3.BackSecondaryColor = System.Drawing.Color.Black;
            title3.BorderColor = System.Drawing.Color.Black;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.Name = "Title";
            title3.Text = "Title";
            this.chartBogo.Titles.Add(title3);
            // 
            // chartInputs
            // 
            chartArea4.Name = "ChartArea1";
            this.chartInputs.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartInputs.Legends.Add(legend4);
            this.chartInputs.Location = new System.Drawing.Point(162, 288);
            this.chartInputs.Name = "chartInputs";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartInputs.Series.Add(series4);
            this.chartInputs.Size = new System.Drawing.Size(334, 234);
            this.chartInputs.TabIndex = 3;
            this.chartInputs.Text = "Chart";
            title4.BackColor = System.Drawing.Color.White;
            title4.BackSecondaryColor = System.Drawing.Color.Black;
            title4.BorderColor = System.Drawing.Color.Black;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title4.Name = "Title";
            title4.Text = "Title";
            this.chartInputs.Titles.Add(title4);
            // 
            // chartShake
            // 
            chartArea5.Name = "ChartArea1";
            this.chartShake.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartShake.Legends.Add(legend5);
            this.chartShake.Location = new System.Drawing.Point(502, 288);
            this.chartShake.Name = "chartShake";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartShake.Series.Add(series5);
            this.chartShake.Size = new System.Drawing.Size(334, 234);
            this.chartShake.TabIndex = 3;
            this.chartShake.Text = "Shake";
            title5.BackColor = System.Drawing.Color.White;
            title5.BackSecondaryColor = System.Drawing.Color.Black;
            title5.BorderColor = System.Drawing.Color.Black;
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title5.Name = "Title";
            title5.Text = "Title";
            this.chartShake.Titles.Add(title5);
            // 
            // cbVisual
            // 
            this.cbVisual.AutoSize = true;
            this.cbVisual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbVisual.Location = new System.Drawing.Point(371, 579);
            this.cbVisual.Name = "cbVisual";
            this.cbVisual.Size = new System.Drawing.Size(154, 28);
            this.cbVisual.TabIndex = 1;
            this.cbVisual.Text = "Визуализация";
            this.cbVisual.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearToolStripMenuItem,
            this.randomToolStripMenuItem,
            this.сортироватьToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 717);
            this.Controls.Add(this.chartShake);
            this.Controls.Add(this.chartInputs);
            this.Controls.Add(this.chartBogo);
            this.Controls.Add(this.chartFast);
            this.Controls.Add(this.chartBubble);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btDataAdd);
            this.Controls.Add(this.cbBogo);
            this.Controls.Add(this.cbVisual);
            this.Controls.Add(this.cbFast);
            this.Controls.Add(this.cbShake);
            this.Controls.Add(this.cbInsert);
            this.Controls.Add(this.cbBubble);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBubble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInputs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartShake)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox cbBubble;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbShake;
        private System.Windows.Forms.CheckBox cbFast;
        private System.Windows.Forms.CheckBox cbBogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Button btDataAdd;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBubble;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBogo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInputs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartShake;
        private System.Windows.Forms.CheckBox cbVisual;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
    }
}

