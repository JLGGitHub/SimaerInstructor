using CaravanInstructor.Dao;
using CaravanInstructor.Database;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ExerciseDaoImp : IExerciseDao
    {
        public bool CreateExercise(exercise InsertExercise)
        {
            using (var db = new DbSimaer())
            {
                db.exercise.Add(InsertExercise);
                db.SaveChanges();

                return true;
            }
        }

        public bool DeleteExercise(exercise DeleteExercise)
        {
            using (var db = new DbSimaer())
            {
                db.exercise.Remove(DeleteExercise);
                db.SaveChanges();

                return true;
            }
        }

        public List<exercise> ReadExercises()
        {
            using (var db = new DbSimaer())
            {
                return db.exercise.ToList();
            }
        }

        public bool UpdateExercise(exercise UpdateExercise)
        {
            using (var db = new DbSimaer())
            {
                db.exercise.AddOrUpdate(UpdateExercise);
                db.SaveChanges();

                return true;
            }
        }
    }
}
