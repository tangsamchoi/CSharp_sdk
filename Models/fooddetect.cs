using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.fooddetect
{
    public class fooddetectResponse : BaseResponse
    {
        /// <summary>
        /// 是否美食
        /// </summary>
        public bool food { get; set; }
        /// <summary>
        /// 模糊参考值,范围 0-1的浮点数,越大置信度越高
        /// </summary>
        public float food_confidence { get; set; }
        /// <summary>
        /// 标示识别请求的序列号
        /// </summary>
        public string seq { get; set; }
    }
}
