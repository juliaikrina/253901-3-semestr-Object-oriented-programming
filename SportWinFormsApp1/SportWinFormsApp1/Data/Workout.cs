using System.ComponentModel.DataAnnotations;

namespace SportWinFormsApp1.Data
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        public string FileName { get; set; }

        public DateTime DateTime { get; set; }

        public double Distance { get; set; }

        

    }
}

