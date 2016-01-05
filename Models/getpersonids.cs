using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.getpersonids
{
    public class getpersonidsResponse : BaseResponse
    {
        /// <summary>
        /// 相应person的id列表
        /// </summary>
        public List<string> person_ids { get; set; }
    }
}
