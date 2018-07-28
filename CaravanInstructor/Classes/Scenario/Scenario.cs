using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Scenario
{
    class Scenario
    {
        #region Variables
        private int _scenarioID_int;
        private string _name_str;
        private RunwayTol _runWayTolID_run;
        private TimeDay _timeDayID_tim;
        #endregion

        #region Getters y Setters
        public int ScenarioID_int
        {
            get
            {
                return this._scenarioID_int;
            }
            set
            {
                this._scenarioID_int = value;
            }
        }

        public string Name_str
        {
            get
            {
                return this._name_str;
            }
            set
            {
                this._name_str = value;
            }
        }

        public RunwayTol RunWayTolID_run
        {
            get
            {
                return this._runWayTolID_run;
            }
            set
            {
                this._runWayTolID_run = value;
            }
        }

        public TimeDay TimeDayID_tim
        {
            get
            {
                return this._timeDayID_tim;
            }
            set
            {
                this._timeDayID_tim = value;
            }
        }

        public string NameRunWayTol_str
        {
            get
            {
                return _runWayTolID_run.Name_str;
            }
            set
            {
                this._runWayTolID_run.Name_str = value;
            }
        }

        public string NameTimeDay_str
        {
            get
            {
                return _timeDayID_tim.Name_str;
            }
            set
            {
                this._timeDayID_tim.Name_str = value;
            }
        }
        #endregion

        public Scenario()
        {
            _scenarioID_int = 0;
            _name_str = "";
            _runWayTolID_run = new RunwayTol();
            _timeDayID_tim = new TimeDay();
        }

        public Scenario(int i_scenarioID, string i_name)
        {
            _scenarioID_int = i_scenarioID;
            _name_str = i_name;
            _runWayTolID_run = new RunwayTol();
            _timeDayID_tim = new TimeDay();
        }

        public static ObservableCollection<Scenario> GetScenarios()
        {
            ObservableCollection<Scenario> scenarios = new ObservableCollection<Scenario>();
            Scenario scenario;

            scenario = new Scenario(0, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(0, "Día", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());

            scenarios.Add(scenario);

            return scenarios;
        }
    }
}
