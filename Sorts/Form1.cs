using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            chartBubble.Titles[0].Text = "Bubble";
            chartBogo.Titles[0].Text = "BOGO";
            chartFast.Titles[0].Text = "Fast";
            chartInputs.Titles[0].Text = "Вставки";
            chartShake.Titles[0].Text = "Shake";
        }

        List<double> items = new List<double>();

        private void btDataAdd_Click(object sender, EventArgs e) {
            int index = 0;
            foreach (DataGridViewRow currRow in dataGridView1.Rows) {
                items.Add(Convert.ToDouble(currRow.Cells[1].Value));
                chartBubble.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                chartBogo.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                chartFast.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                chartInputs.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                chartShake.Series[0].Points.AddXY(index, Convert.ToDouble(currRow.Cells[1].Value));
                index++;
            }
            items.Remove(items.Last());
        }
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = dataGridView1.Rows.Count - 1;
        }

        private async void btSort_Click(object sender, EventArgs e) {
            chartBubble.Titles[0].Text = "Bubble";
            chartBogo.Titles[0].Text = "BOGO";
            chartFast.Titles[0].Text = "Fast";
            chartInputs.Titles[0].Text = "Вставки";
            chartShake.Titles[0].Text = "Shake";

            double[] array = new double[items.Count];
            array = addArray(array);
            Parallel.Invoke(
                () => {
                    if (cbBubble.Checked) {
                        //await Task.Run(() => { DrawBubbleSortAsync(array); });
                        DrawBubbleSortAsync(array);
                        //DrawBubbleSortAsync(array);
                    }
                }, () => {
                    if (cbInsert.Checked) {
                        //await Task.Run(() => { SortInputs(array); });
                        SortInputs(array);
                        //SortInputs(array);
                    }
                }, () => {
                    if (cbFast.Checked) {
                        //await Task.Run(() => { FastSort(array); return Task.CompletedTask; });
                        //FastSort(array);
                        //FastSort(array);
                    }
                }, () => {
                    if (cbShake.Checked) {
                        //await Task.Run(() => { ShakeSort(array); });
                        ShakeSort(array);
                    }
                }, () => {

                    if (cbBogo.Checked) {
                        //await Task.Run(() => { BogoSort(array); });
                        BogoSort(array);
                    }
                });
        }
        private double[] addArray(double[] array) {
            int index = 0;
            foreach (var item in items) {
                array[index] = item;
                index++;
            }
            return array;
        }
        private void DrawTimeResult(Chart c, string text) {
            c.Invoke(new Action(() => c.Titles[0].Text += " " + text + "мс"));
        }
        #region Сортировки

        #region Сортировка Пузырьком

        private double[] DrawBubbleSortAsync(double[] array) {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            double temp;

            for (int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] > array[j]) {


                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        if (cbVisual.Checked) {
                            sw.Stop();
                            //Invoke(new Action(() => Visualization(chartBubble, array)));
                            Visualization(chartBubble, array);
                            sw.Start();
                        }

                    }
                }
            }
            Wait(1);
            sw.Stop();
            DrawTimeResult(chartBubble, sw.ElapsedMilliseconds.ToString());
            //chartBubble.Titles[0].Text += " " + sw.ElapsedMilliseconds.ToString() + "мс";

            return array;
        }
        #endregion
        #region Сортировка вставками
        private double[] SortInputs(double[] array) {
            Stopwatch SW = new Stopwatch();
            SW.Start();


            for (int i = 1; i < array.Length; i++) {
                double k = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > k) {
                    array[j + 1] = array[j];
                    array[j] = k;
                    j--;
                    if (cbVisual.Checked) {
                        SW.Stop();
                        //Invoke(new Action(() => Visualization(chartInputs, array)));
                        Visualization(chartInputs, array);
                        SW.Start();
                    }
                }
            }
            Wait(1);
            SW.Stop();
            DrawTimeResult(chartInputs, SW.ElapsedMilliseconds.ToString());

            //chartInputs.Titles[0].Text += " " + SW.ElapsedMilliseconds.ToString() + "мс";
            return array;
        }
        #endregion

        #region shake
        private double[] ShakeSort(double[] Array) {
            Stopwatch SW = new Stopwatch();
            
            SW.Start();
            int left = 0,
            right = Array.Length - 1;
            while (left < right) {
                for (int i = left; i < right; i++) {
                    if (Array[i] > Array[i + 1]) {
                        SW.Stop();
                        Swap(chartShake, Array, i, i + 1);
                        SW.Start();
                        if (cbVisual.Checked) {
                            SW.Stop();
                            Invoke(new Action(() => Visualization(chartShake, Array)));
                            SW.Start();
                        }
                    }
                }
                right--;
                for (int i = right; i > left; i--) {
                    if (Array[i - 1] > Array[i]) {
                        SW.Stop();
                        Swap(chartShake, Array, i - 1, i);
                        SW.Start();
                        if (cbVisual.Checked) {
                            SW.Stop();
                            Invoke(new Action(() => Visualization(chartShake, Array)));
                            SW.Start();
                        }
                    }
                }
                left++;
            }
            Wait(1);
            SW.Stop();
            DrawTimeResult(chartShake, SW.ElapsedMilliseconds.ToString());
            //chartShake.Titles[0].Text += " " + SW.ElapsedMilliseconds.ToString() + "мс";
            return Array;
        }
        #endregion

        #region Fast
        private double[] FastSort(double[] Array) {

            Stopwatch SW = new Stopwatch();
            SW.Start();
            var stack = new Stack<int>();

            double pivot;
            int pivotIndex = 0;
            int leftIndex = pivotIndex + 1;
            int rightIndex = Array.Length - 1;

            stack.Push(pivotIndex);
            stack.Push(rightIndex);

            int leftIndexOfSubSet, rightIndexOfSubset;

            while (stack.Count > 0) {
                if (cbVisual.Checked) {
                    SW.Stop();
                    Invoke(new Action(() => Visualization(chartFast, Array)));
                   // Visualization(chartFast, Array);
                    SW.Start();
                }
                rightIndexOfSubset = stack.Pop();
                leftIndexOfSubSet = stack.Pop();

                leftIndex = leftIndexOfSubSet + 1;
                pivotIndex = leftIndexOfSubSet;
                rightIndex = rightIndexOfSubset;

                pivot = Array[pivotIndex];

                if (leftIndex > rightIndex) {
                    continue;
                }

                while (leftIndex < rightIndex) {
                    while (( leftIndex <= rightIndex ) && ( Array[leftIndex] <= pivot )) {
                        leftIndex++;
                    }

                    while (( leftIndex <= rightIndex ) && ( Array[rightIndex] >= pivot )) {
                        rightIndex--;
                    }

                    if (rightIndex >= leftIndex) {
                        SW.Stop();
                        Swap(chartFast, Array, leftIndex, rightIndex);
                        SW.Start();
                    }
                }

                if (pivotIndex <= rightIndex) {
                    if (Array[pivotIndex] > Array[rightIndex]) {
                        SW.Stop();
                        Swap(chartFast, Array, pivotIndex, rightIndex);
                        SW.Start();
                    }
                }

                if (leftIndexOfSubSet < rightIndex) {
                    stack.Push(leftIndexOfSubSet);
                    stack.Push(rightIndex - 1);
                }

                if (rightIndexOfSubset > rightIndex) {
                    stack.Push(rightIndex + 1);
                    stack.Push(rightIndexOfSubset);
                }
            }
            Wait(1);
            SW.Stop();
            DrawTimeResult(chartFast, SW.ElapsedMilliseconds.ToString());

            return Array;
            //chartFast.Titles[0].Text += " " + SW.ElapsedMilliseconds.ToString() + "мс";
        }
        #endregion
        #region Bogo
        public void BogoSort(double[] Array) {
            double Temp;
            int Rnd;
            Stopwatch SW = new Stopwatch();
            Random Random = new Random();
            SW.Start();
            while (!IsSorted(Array)) {
                for (int i = 0; i < Array.Length; ++i) {
                    Rnd = Random.Next(Array.Length);
                    Temp = Array[i];
                    Array[i] = Array[(int)Rnd];
                    Array[(int)Rnd] = Temp;
                    if (cbVisual.Checked) {
                        Invoke(new Action(() => Visualization(chartBogo, Array)));
                    }
                }
            }
            Wait(1);
            SW.Stop();
            DrawTimeResult(chartBogo, SW.ElapsedMilliseconds.ToString());
            //chartBogo.Titles[0].Text += " " + SW.ElapsedMilliseconds.ToString() + "мс";
        }
        #endregion
        #endregion

        private bool IsSorted(double[] Array) {
            int Count = Array.Length;
            while (--Count >= 1) {
                if (Array[Count] < Array[Count - 1]) {
                    return false;
                }
            }
            return true;
        }

        public void Visualization(Chart c, double[] Array) {
            c.Series[0].Points.Clear();

            for (int i = 0; i < Array.Length; i++) {
                c.Series[0].Points.AddY(Array[i]);
            }
            Wait(0.001);
        }

        private void Wait(double seconds) {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks) {
                Application.DoEvents();
            }
        }
        private void Swap(Chart c, double[] array, int i, int j) {
            double Temp = array[i];
            array[i] = array[j];
            array[j] = Temp;
            if (cbVisual.Checked) {
                Invoke(new Action(() => Visualization(c, array)));
            }
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e) {
            items.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Rows[0].Cells[0].Value = 0;
            try {
                chartBubble.Series[0].Points.Clear();
                chartBogo.Series[0].Points.Clear();
                chartFast.Series[0].Points.Clear();
                chartInputs.Series[0].Points.Clear();
                chartShake.Series[0].Points.Clear();
            } catch (Exception) {

            }

        }
        bool isFirstClick = true;

        private void randomToolStripMenuItem_Click(object sender, EventArgs e) {
            if (isFirstClick) { isFirstClick = false; } else {
                ClearToolStripMenuItem_Click(sender, e);
            }


            Random Random = new Random();
            double[] RandomArray = new double[100];
            for (int i = 0; i < RandomArray.Length; i++) {
                RandomArray[i] = Random.Next(1, 10);
                dataGridView1.Rows.Add(i, RandomArray[i]);
            }

            //btDataAdd_Click(sender, e);
        }
    }
}
