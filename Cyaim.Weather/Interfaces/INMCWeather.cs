using Cyaim.Weather.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApiClient;
using WebApiClient.Attributes;
using WebApiClient.DataAnnotations;

namespace Cyaim.Weather.Interfaces
{
    /// <summary>
    /// 中央气象台
    /// </summary>
    public interface INMCWeather : IHttpApi
    {
        /// <summary>
        /// 获取所有省市
        /// </summary>
        /// <returns></returns>
        [HttpGet("http://www.nmc.cn/rest/province/all")]
        Task<ProvinceModel> GetProvinceAll();


        /// <summary>
        /// 根据省份获取市
        /// </summary>
        /// <returns></returns>
        [HttpGet("http://www.nmc.cn/rest/province/{province}")]
        Task<CityModel> GetCityByProvince(string province);


        /// <summary>
        /// 根据地区代码获取天气
        /// </summary>
        /// <returns></returns>
        [HttpGet("http://www.nmc.cn/rest/weather")]
        Task<WeatherModel> GetWeather(string stationid);


        /// <summary>
        /// 根据IP或地区代码获取地区信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("http://www.nmc.cn/rest/position")]
        Task<CityItem> GetPosition(string stationid = "");


    }
}
