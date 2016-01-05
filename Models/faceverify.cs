using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.faceverify
{
    public class faceverifyResponse : BaseResponse
    {
        /// <summary>
        /// 系统对这个判断的置信度
        /// </summary>
        public float confidence { get; set; }
        /// <summary>
        /// 两个输入是否为同一人的判断
        /// </summary>
        public bool ismatch { get; set; }
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
    }
}
