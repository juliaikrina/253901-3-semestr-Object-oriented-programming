using SportWinFormsApp1.modles.Activity;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportWinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ActivityModel Avg = null; // объявили снаружи try

                try
                {
                    var fileName = openFileDialog1.FileName;

                    var content = File.ReadAllText(fileName);

                    Avg = JsonSerializer.Deserialize<ActivityModel>(content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Некорректный файл ({ex.Message})");
                    return;
                }


                listBox1.Items.Clear();
                listBox1.Items.Add($"Файл: {Path.GetFileName(openFileDialog1.FileName)}");

                int lapNumber = 1;

                foreach (var winItem in Avg.DeviceLog.Windows)
                {
                    var hr = winItem.Window?.HR?.FirstOrDefault();
                    if (hr == null)
                        continue;

                    dataGridView1.Rows.Add(
                        lapNumber,                              // Круг
                        Math.Round((hr.Avg ?? 0) * 60, 1),      // Средний пульс
                        Math.Round((hr.Max ?? 0) * 60, 1),      // Максимальный пульс
                        Math.Round((hr.Min ?? 0) * 60, 1));     // Минимальный пульс

                    lapNumber++;
                }
                foreach (var winItem in Avg.DeviceLog.Windows)
                {
                    if (winItem.Window?.HR != null && winItem.Window.HR.Count > 0)
                    {
                        var hr = winItem.Window.HR.First();

                        double avgHr = (hr.Avg ?? 0) * 60;

                        listBox1.Items.Add($"Круг {lapNumber}: Средний = {avgHr:F1}");
                        lapNumber++;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}