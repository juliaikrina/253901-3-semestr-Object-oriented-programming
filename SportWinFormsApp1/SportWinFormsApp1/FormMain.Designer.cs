namespace SportWinFormsApp1
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьФайлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            Круг = new DataGridViewTextBoxColumn();
            Avg = new DataGridViewTextBoxColumn();
            Max = new DataGridViewTextBoxColumn();
            Min = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            workoutBindingSource = new BindingSource(components);
            workoutBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fileNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Distance = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Json|*.json";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(828, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьФайлToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьФайлToolStripMenuItem
            // 
            открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            открытьФайлToolStripMenuItem.Size = new Size(153, 22);
            открытьФайлToolStripMenuItem.Text = "Открыть файл";
            открытьФайлToolStripMenuItem.Click += открытьФайлToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(153, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(32, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 139);
            listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Круг, Avg, Max, Min });
            dataGridView1.Location = new Point(32, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(530, 218);
            dataGridView1.TabIndex = 3;
            // 
            // Круг
            // 
            Круг.HeaderText = "Круг";
            Круг.Name = "Круг";
            // 
            // Avg
            // 
            Avg.HeaderText = "Средний пульс";
            Avg.Name = "Avg";
            // 
            // Max
            // 
            Max.HeaderText = "Максимальный пульс";
            Max.Name = "Max";
            // 
            // Min
            // 
            Min.HeaderText = "Минимальный пульс";
            Min.Name = "Min";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 4;
            label1.Text = "Общая Информация";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 207);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 5;
            label2.Text = "Данные о пульсе";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fileNameDataGridViewTextBoxColumn, dateTimeDataGridViewTextBoxColumn, Distance });
            dataGridView2.DataSource = workoutBindingSource;
            dataGridView2.Location = new Point(388, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(310, 139);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // workoutBindingSource
            // 
            workoutBindingSource.DataSource = typeof(Data.Workout);
            // 
            // workoutBindingSource1
            // 
            workoutBindingSource1.DataSource = typeof(Data.Workout);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // Distance
            // 
            Distance.DataPropertyName = "Distance";
            Distance.HeaderText = "Distance";
            Distance.Name = "Distance";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 485);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)workoutBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьФайлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Круг;
        private DataGridViewTextBoxColumn Avg;
        private DataGridViewTextBoxColumn Max;
        private DataGridViewTextBoxColumn Min;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn distanceKmDataGridViewTextBoxColumn;
        private BindingSource workoutBindingSource1;
        private BindingSource workoutBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Distance;
    }
}
