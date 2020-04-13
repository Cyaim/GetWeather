using Cyaim.Weather.Interfaces;
using Cyaim.Weather.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using WebApiClient;

namespace Cyaim.Weather
{
    public class WeatherManager
    {
        static WeatherManager()
        {
            HttpApi.Register<INMCWeather>();
        }

        /// <summary>
        /// 省份信息
        /// </summary>
        public static ProvinceItemModel[] Provinces
        {
            get
            {
                var pTask = GetProvince(null);
                pTask.Wait();
                return pTask.Result.ProvinceItems;
            }
        }

        /// <summary>
        /// 获取省份信息
        /// </summary>
        /// <param name="provinceName"></param>
        /// <returns></returns>
        public static async Task<ProvinceModel> GetProvince(string provinceName)
        {
            using (INMCWeather wApi = HttpApi.Resolve<INMCWeather>())
            {
                var p = await wApi.GetProvinceAll();

                if (string.IsNullOrEmpty(provinceName))
                {
                    return p;
                }
                p.ProvinceItems = p.ProvinceItems.Where(x => x.name.Contains(provinceName)).ToArray();
                return p;
            }
        }

        /// <summary>
        /// 根据地区代码（字母）获取市信息
        /// </summary>
        /// <param name="code">地区代码</param>
        /// <returns></returns>
        public static async Task<CityItem[]> GetCity(string code)
        {
            using (INMCWeather wApi = HttpApi.Resolve<INMCWeather>())
            {
                var p = await wApi.GetCityByProvince(code);
                return p.CityItems;
            }
        }

        /// <summary>
        /// 根据地区代码（数字）获取天气信息
        /// </summary>
        /// <param name="code">地区代码</param>
        /// <returns></returns>
        public static async Task<WeatherData> GetWheather(string code)
        {
            using (INMCWeather wApi = HttpApi.Resolve<INMCWeather>())
            {
                var p = await wApi.GetWeather(code);
                if (p.code == 0)
                {
                    return p.data;
                }
                return null;
            }
        }

        /// <summary>
        /// 根据地区代码（数字）获取地区信息
        /// </summary>
        /// <param name="code">地区代码</param>
        /// <returns></returns>
        public static async Task<CityItem> GetPosition(string code = "")
        {
            using (INMCWeather wApi = HttpApi.Resolve<INMCWeather>())
            {
                var p = await wApi.GetPosition(code);

                return p;
            }
        }
    }
}
