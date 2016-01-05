using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.getgroupids
{
    public class getgroupidsResponse : BaseResponse
    {
        /// <summary>
        /// 相应app_id的group_id列表
        /// </summary>
        public List<string> group_ids { get; set; }
    }
}
