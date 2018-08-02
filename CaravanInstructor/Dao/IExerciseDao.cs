using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IExerciseDao
    {
        bool CreateExercise(exercise InsertExercise);
        bool UpdateExercise(exercise UpdateExercise);
        bool DeleteExercise(exercise DeleteExercise);
        List<exercise> ReadExercises();
    }
}
