using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Common
{
    public class JsonHelper<T>
    {
        /// <summary>
        /// 类型实例转Json字符串
        /// </summary>
        /// <param name="t">类型实例</param>
        /// <returns></returns>
        public static string ToJson(T t)
        {
            IsoDateTimeConverter a = new IsoDateTimeConverter();
            string result = JsonConvert.SerializeObject(t, a);
            return result;
        }
        /// <summary>
        /// Json字符串转类型实例
        /// </summary>
        /// <param name="jsonStr"></param>
        /// <returns></returns>
        public static T ToEntity(string jsonStr)
        {
            T t = JsonConvert.DeserializeObject<T>(jsonStr);
            return t;
        }
    }
}
