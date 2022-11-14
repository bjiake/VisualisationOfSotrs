using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sorts {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            DataTable table = new DataTable();
            table.Columns.Add("index", typeof(int));
            table.Columns.Add("value", typeof(double));
            dataGridView1.Rows[0].Cells[0].Value = 0;
        }

        List<double> items = new List<double>();

        private void btDataAdd_Click(object sender, EventArgs e) {
            int index = 0;
            foreach (DataGridViewRow currRow in dataGridView1.Rows) {
                items.Add(Convert.ToDouble(currRow.Cells[1].Value));
                chart1.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                    index++;
            }
            items.Remove(items.Last());
        }

       

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count - 1;
        }

        public struct PointD {
            public double X;
            public double Y;

            public PointD(double x, double y) {
                X = x;
                Y = y;
            }

            public Point ToPoint() {
                return new Point((int)X, (int)Y);
            }

            public override bool Equals(object obj) {
                return obj is PointD && this == (PointD)obj;
            }
            public override int GetHashCode() {
                return X.GetHashCode() ^ Y.GetHashCode();
            }
            public static bool operator ==(PointD a, PointD b) {
                return a.X == b.X && a.Y == b.Y;
            }
            public static bool operator !=(PointD a, PointD b) {
                return !( a == b );
            }
        }

        private void btSort_Click(object sender, EventArgs e) {
            if (cbBubble.Checked) {
                chart1.Titles[0].Text = "Bubble";

                //Секундомер
                Time timeBubble = new Time();
                timeBubble.TimeStart();
                string resultTime = String.Empty;

                //Сама сортировка
                SortBubble();
                resultTime = timeBubble.TimeEnd();

                //Визуализация сортировки
                DrawBubbleSortAsync();
                //PointD tempPoint = new PointD();
                //tempPoint.Y = chart1.Series[0].Points[0].YValues[0];

                //Thread.Sleep(1000);
                //chart1.Series[0].Points[0].YValues[0] = chart1.Series[0].Points[1].YValues[0];

                //Thread.Sleep(1000);
                //chart1.Series[0].Points[1].YValues[0] = tempPoint.Y;

                //Остановка секундомера
                lbTimer.Text = resultTime;
            } else if (cbInsert.Checked) {

            } else if (cbFast.Checked) {

            } else if (cbShake.Checked) { 

            } else if (cbBogo.Checked) {

            }
        }
        private double[] addArray(double[] array) {
            int index = 0;
            foreach (var item in items) {
                array[index] = item;
                index++;
            }
            return array;
        }



        private void DrawBubbleSortAsync() {
            double temp;
            PointD tempPoint = new PointD();


            double[] array = new double[items.Count];
            array = addArray(array);


            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {


                        temp = array[i];
                        tempPoint.Y = chart1.Series[0].Points[i].YValues[0];

                        Thread thread1 = new Thread(() => {
                            array[i] = array[j];
                            chart1.Series[0].Points[i].YValues[0] = chart1.Series[0].Points[j].YValues[0];
                        });
                        thread1.Start();
                        
                        
                        Thread thread2 = new Thread(() => {
                            array[j] = temp;
                            chart1.Series[0].Points[j].YValues[0] = tempPoint.Y;
                            Thread.Sleep(1000);
                        });
                        thread2.Start();
                        
                    }
                }
            }


        }
        #region Сортировка Пузырьком
        private double[] SortBubble() {
            double temp;

            double[] array = new double[items.Count];
            array = addArray(array);

            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
            
        }
        #endregion
    }
}
