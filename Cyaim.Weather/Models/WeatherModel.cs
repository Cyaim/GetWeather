using System;
using System.Collections.Generic;
using System.Text;

namespace Cyaim.Weather.Models
{
    public class WeatherModel
    {
        public string msg { get; set; }
        public int code { get; set; }
        public WeatherData data { get; set; }
    }

    public class WeatherData
    {
        public Real real { get; set; }
        public Predict predict { get; set; }
        public Air air { get; set; }
        public TempchartItem[] tempchart { get; set; }
        public PassedchartItem[] passedchart { get; set; }
        public Climate climate { get; set; }
        public Radar radar { get; set; }
    }

    public struct Real
    {
        public Station station { get; set; }
        public string publish_time { get; set; }
        public Weather weather { get; set; }
        public Wind wind { get; set; }
        public Warn warn { get; set; }
    }

    public struct Station
    {
        public string code { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string url { get; set; }
    }

    public struct Weather
    {
        public float temperature { get; set; }
        public float temperatureDiff { get; set; }
        public int airpressure { get; set; }
        public int humidity { get; set; }
        public int rain { get; set; }
        public int rcomfort { get; set; }
        public int icomfort { get; set; }
        public string info { get; set; }
        public string img { get; set; }
        public int feelst { get; set; }
    }

    public struct Wind
    {
        public string direct { get; set; }
        public string power { get; set; }
        public string speed { get; set; }
    }

    public struct Warn
    {
        public string alert { get; set; }
        public string pic { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string url { get; set; }
        public string issuecontent { get; set; }
        public string fmeans { get; set; }
        public string signaltype { get; set; }
        public string signallevel { get; set; }
        public string pic2 { get; set; }
    }

    public struct Predict
    {
        public Station1 station { get; set; }
        public string publish_time { get; set; }
        public Detail[] detail { get; set; }
    }

    public struct Station1
    {
        public string code { get; set; }
        public string province { get; set; }
        public string city { get; set; }
        public string url { get; set; }
    }

    public struct Detail
    {
        public string date { get; set; }
        public string pt { get; set; }
        public Day day { get; set; }
        public Night night { get; set; }
    }

    public struct Day
    {
        public Weather1 weather { get; set; }
        public Wind wind { get; set; }
    }

    public struct Weather1
    {
        public string info { get; set; }
        public string img { get; set; }
        public string temperature { get; set; }
    }

    public struct Night
    {
        public Weather1 weather { get; set; }
        public Wind wind { get; set; }
    }

    public struct Air
    {
        public string forecasttime { get; set; }
        public int aqi { get; set; }
        public int aq { get; set; }
        public string text { get; set; }
        public string aqiCode { get; set; }
    }

    public class Climate
    {
        public string time { get; set; }
        public MonthItem[] month { get; set; }
    }

    public struct MonthItem
    {
        public int month { get; set; }
        public float maxTemp { get; set; }
        public float minTemp { get; set; }
        public float precipitation { get; set; }
    }

    public struct Radar
    {
        public string title { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public struct TempchartItem
    {
        public string time { get; set; }
        public float max_temp { get; set; }
        public float min_temp { get; set; }
        public string day_img { get; set; }
        public string day_text { get; set; }
        public string night_img { get; set; }
        public string night_text { get; set; }
    }

    public struct PassedchartItem
    {
        public int rain1h { get; set; }
        public int rain24h { get; set; }
        public int rain12h { get; set; }
        public int rain6h { get; set; }
        public float temperature { get; set; }
        public string tempDiff { get; set; }
        public int humidity { get; set; }
        public int pressure { get; set; }
        public int windDirection { get; set; }
        public float windSpeed { get; set; }
        public string time { get; set; }
    }

}
