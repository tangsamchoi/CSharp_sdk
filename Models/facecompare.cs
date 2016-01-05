using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.facecompare
{
    public class facecompareResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 两个face的相似度
        /// </summary>
        public float similarity { get; set; }
    }
}
