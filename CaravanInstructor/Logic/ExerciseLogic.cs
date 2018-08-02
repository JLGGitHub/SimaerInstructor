using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class ExerciseLogic
    {
        private readonly IExerciseDao dao;

        public ExerciseLogic()
        {
            dao = new ExerciseDaoImp();
        }

        public bool CreateExercise(exercise InsertExercise)
        {
            return dao.CreateExercise(InsertExercise);
        }

        public bool DeleteExercise(exercise DeleteExercise)
        {
            return dao.DeleteExercise(DeleteExercise);
        }

        public List<exercise> ReadExercises()
        {
            return dao.ReadExercises();
        }

        public bool UpdateExercise(exercise UpdateExercise)
        {
            return dao.UpdateExercise(UpdateExercise);
        }

    }
}
