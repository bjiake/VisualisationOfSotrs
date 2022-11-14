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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbBubble = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbShake = new System.Windows.Forms.CheckBox();
            this.cbFast = new System.Windows.Forms.CheckBox();
            this.cbBogo = new System.Windows.Forms.CheckBox();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDataAdd = new System.Windows.Forms.Button();
            this.btSort = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.value});
            this.dataGridView1.Location = new System.Drawing.Point(250, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(207, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // cbBubble
            // 
            this.cbBubble.AutoSize = true;
            this.cbBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBubble.Location = new System.Drawing.Point(25, 408);
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
            this.cbInsert.Location = new System.Drawing.Point(25, 476);
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
            this.cbShake.Location = new System.Drawing.Point(25, 510);
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
            this.cbFast.Location = new System.Drawing.Point(25, 374);
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
            this.cbBogo.Location = new System.Drawing.Point(25, 442);
            this.cbBogo.Name = "cbBogo";
            this.cbBogo.Size = new System.Drawing.Size(85, 28);
            this.cbBogo.TabIndex = 1;
            this.cbBogo.Text = "BOGO";
            this.cbBogo.UseVisualStyleBackColor = true;
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
            // btDataAdd
            // 
            this.btDataAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btDataAdd.Location = new System.Drawing.Point(250, 566);
            this.btDataAdd.Name = "btDataAdd";
            this.btDataAdd.Size = new System.Drawing.Size(181, 30);
            this.btDataAdd.TabIndex = 2;
            this.btDataAdd.Text = "Внести данные";
            this.btDataAdd.UseVisualStyleBackColor = true;
            this.btDataAdd.Click += new System.EventHandler(this.btDataAdd_Click);
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSort.Location = new System.Drawing.Point(25, 566);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(181, 30);
            this.btSort.TabIndex = 2;
            this.btSort.Text = "Начать сортировку";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 356);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Chart";
            title1.BackColor = System.Drawing.Color.White;
            title1.BackSecondaryColor = System.Drawing.Color.Black;
            title1.BorderColor = System.Drawing.Color.Black;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title";
            title1.Text = "Title";
            this.chart1.Titles.Add(title1);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTime.Location = new System.Drawing.Point(463, 374);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(242, 24);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Скорость сортировки(мс)";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTimer.Location = new System.Drawing.Point(705, 374);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 24);
            this.lbTimer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.btDataAdd);
            this.Controls.Add(this.cbBogo);
            this.Controls.Add(this.cbFast);
            this.Controls.Add(this.cbShake);
            this.Controls.Add(this.cbInsert);
            this.Controls.Add(this.cbBubble);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbTimer;
    }
}

