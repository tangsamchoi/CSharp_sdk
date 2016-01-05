using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models
{
    public class BaseResponse
    {
        /// <summary>
        /// 返回状态值
        /// </summary>
        public int errorcode { get; set; }
        /// <summary>
        /// 返回错误消息
        /// </summary>
        public string errormsg { get; set; }
    }
}
