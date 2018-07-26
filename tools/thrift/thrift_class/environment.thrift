namespace cpp environment
namespace csharp environment

enum WindTurbulenceLevel {
    turbNone = 0,
	turbLow = 1,
	turbMedium = 2,
	turbMax = 3,
}

struct CloudParameters {
    1: i32 LayerIndex
    2: string LayerName
    3: string CloudTypeName
    4: double LayerTop
    5: double LayerBase
    6: i32 CloudCoverage
    7: optional double Density
    8: optional double Lightning
}

struct TimeOfDayParameters{
    1: i32 Hour 
    2: i32 Minute
    3: i32 Second
}

struct PrecipitationParameter{
    1: string Type
    2: double Amount     
}

struct WindSpeedParameters{
    1: double WindSpeed;
	2: double WindDirection;
	3: WindTurbulenceLevel TurbulenceLevel = WindTurbulenceLevel.turbNone;    
    4: optional bool IsUseVariableWind;
	5: optional double WindSpeedMaxDev;
	6: optional double WindDirMaxDev;
	7: optional double WindTimeIntervalAvg;
	8: optional double WindTimeIntervalMaxDev;
}

struct VisibilityParameters{
    1: double Visibility
    2: double MistDistance
    3: double MistHeight
}

struct WeatherParameters{
    1: WindSpeedParameters WindSpeedParams 
    2: VisibilityParameters VisibilityParams
}

service EnvironmentService{
    void SetCurrentSystemTime(),	
    void SetTimeOfDay(1:TimeOfDayParameters TimeOfDayParams),		        
    void SetPrecipitation(1:PrecipitationParameter PrecipitationParams),
    void SetWind(1: WindSpeedParameters WindParms),
    void SetVisibility(1:VisibilityParameters VisibilityParams),
    void SetWeather(1:WeatherParameters WeatherParams),
    void SetCloud(1:CloudParameters CloudParms),	
    void SetEmptyClouds()
}
