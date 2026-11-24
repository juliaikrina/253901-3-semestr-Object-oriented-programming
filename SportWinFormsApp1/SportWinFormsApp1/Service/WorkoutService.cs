using SportWinFormsApp1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportWinFormsApp1.Servises
{
    public class WorkoutService
    {
        private readonly WorkoutContext _context;

        public WorkoutService(WorkoutContext context)
        {
            _context = context;
        }

        public List<Workout> GetAll()
        {
            return _context.Workouts.ToList();
        }
        public Workout? GetById(int Id)
        {
            return _context.Workouts.FirstOrDefault(x => x.Id == Id);
        }
        public void Add(Workout workout)
        {
            _context.Workouts.Add(workout);
            _context.SaveChanges();
        }
    }

}
