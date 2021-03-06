﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models
{
    public class setinfoResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 成功删除的person_id
        /// </summary>
        public string person_id { get; set; }
    }
}
