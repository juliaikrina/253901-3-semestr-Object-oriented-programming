using SportWinFormsApp1.Data;
using SportWinFormsApp1.modles.Activity;
using SportWinFormsApp1.Servises;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SportWinFormsApp1
{
    public partial class FormMain : Form
    {
        private readonly WorkoutService _workoutService;
        public FormMain(WorkoutService workoutService)
        {
            InitializeComponent();

            _workoutService = workoutService;

            LoadWorkouts();
            var x = _workoutService.GetAll();
        }
        private void LoadWorkouts()
        {
            workoutBindingSource.DataSource = _workoutService.GetAll();
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

                _workoutService.Add(new Workout()
                {
                    FileName = Path.GetFileName(openFileDialog1.FileName),
                    DateTime = Avg.DeviceLog.Header.DateTime,
                    Distance = Avg.DeviceLog.Header.Distance
                });
                LoadWorkouts();

                //listBox1.Items.Clear();
                //listBox1.Items.Add($"Файл: {Path.GetFileName(openFileDialog1.FileName)}");
                //double distanceMeters = Avg.DeviceLog.Header.Distance;
                //DateTime DateTime = Avg.DeviceLog.Header.DateTime;

                //// Переводим метры в километры 
                //double distanceKm = distanceMeters / 1000.0;

                //listBox1.Items.Add($"Время тренировки: {DateTime:dd.MM.yyyy HH:mm:ss}");
                //listBox1.Items.Add($"Дистанция: {distanceKm:F2} км");

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




                        lapNumber++;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var workoutId = (int)dataGridView2.Rows[e.RowIndex].Cells[0].Value;
            var workout = _workoutService.GetById(workoutId);

            if (workout != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add($"Файл: {workout.FileName}");
                listBox1.Items.Add($"Время тренировки: {workout.DateTime:dd.MM.yyyy HH:mm:ss}");
                listBox1.Items.Add($"Дистанция: {workout.Distance} км");


            }
        }
    }
}