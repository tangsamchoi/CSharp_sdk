using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.getfaceids
{
    public class getfaceidsResponse : BaseResponse
    {
        /// <summary>
        /// 相应face的id列表
        /// </summary>
        public List<string> face_ids { get; set; }
    }
}
