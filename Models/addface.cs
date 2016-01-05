using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.addface
{
    public class addfaceResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 增加的人脸ID列表
        /// </summary>
        public List<string> face_ids { get; set; }
        /// <summary>
        /// 成功加入的face数量
        /// </summary>
        public int added { get; set; }
    }
}
