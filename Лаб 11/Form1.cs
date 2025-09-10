using System.Data;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Лаб_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Resize()
        {
            dataGridView1.Width = 620;
            dataGridView2.Width = 620;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            if (radioButton2.Checked)
            {
                Operator.AutoCreate(ref dataGridView1);
                Operator.AutoCreate(ref dataGridView2);
            }

            else
            {
                Resize();
                Operator.ManualCreate(ref dataGridView1);
                Operator.ManualCreate(ref dataGridView2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            int ind = 0;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Rows[0].Cells[i].Value == null || dataGridView2.Rows[0].Cells[i].Value == null)
                {
                    ind = 1;
                    break;
                }
            }
            if (ind == 0)
                Operator.Calculate(ref dataGridView1, ref dataGridView2, ref dataGridView3);
            else
            {
                MessageBox.Show("Заполните значениями все ячейки!");
                dataGridView1.Enabled = true;
                dataGridView2.Enabled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            dataGridView3.ColumnCount = Convert.ToInt32(numericUpDown1.Value - 1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Enabled = false;
            dataGridView2.Enabled = false;
            numericUpDown1.Minimum = 2;
            numericUpDown1.Maximum = 6;
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView3.ColumnHeadersVisible = false;
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 2;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 2;
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = 1;
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == (char)Keys.Back)
                return;
            e.KeyChar = '\0';
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox text = e.Control as TextBox;
            text.MaxLength = 2;
            text.KeyPress -= KeyPress;
            text.KeyPress += KeyPress;
        }
    }

    static public class Operator
    {
        public static void AutoCreate(ref System.Windows.Forms.DataGridView data)
        {
            Random random = new Random();
            for (int i = 0; i < data.Columns.Count; i++)
            {
                data.Rows[0].Cells[i].Value = random.Next(50);
            }
        }
        public static void ManualCreate(ref System.Windows.Forms.DataGridView data)
        {
            data.Enabled = true;
        }
        public static void Calculate(ref System.Windows.Forms.DataGridView data1, ref System.Windows.Forms.DataGridView data2, ref System.Windows.Forms.DataGridView data3)
        {
            for (int i = 0; i < data3.ColumnCount; i++)
            {
                data3.Rows[0].Cells[i].Value = Convert.ToInt32(data1.Rows[0].Cells[i].Value) * Convert.ToInt32(data1.Rows[0].Cells[i+1].Value) + Convert.ToInt32(data2.Rows[0].Cells[i].Value) * Convert.ToInt32(data2.Rows[0].Cells[i+1].Value);
            }
        }
    }
}
