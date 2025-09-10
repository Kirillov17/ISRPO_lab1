namespace Лаб_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 184);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Масив A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 242);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Массив B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 299);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Массив C";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(58, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Способ ввода массивов A и B";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 66);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(142, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Случайным образом";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "С клавиатуры";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(283, 76);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 51);
            label4.Name = "label4";
            label4.Size = new Size(200, 15);
            label4.TabIndex = 5;
            label4.Text = "Число элемментов массивов A и B";
            // 
            // button1
            // 
            button1.Location = new Point(283, 105);
            button1.Name = "button1";
            button1.Size = new Size(149, 23);
            button1.TabIndex = 6;
            button1.Text = "Ввести массивы А и В";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(283, 135);
            button2.Name = "button2";
            button2.Size = new Size(148, 23);
            button2.TabIndex = 10;
            button2.Text = "Рассчитать массив С";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(163, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(603, 27);
            dataGridView1.TabIndex = 11;
            dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Enabled = false;
            dataGridView2.Location = new Point(163, 230);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(603, 27);
            dataGridView2.TabIndex = 12;
            dataGridView2.EditingControlShowing += dataGridView1_EditingControlShowing;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Enabled = false;
            dataGridView3.Location = new Point(163, 287);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(503, 27);
            dataGridView3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
    }
}
