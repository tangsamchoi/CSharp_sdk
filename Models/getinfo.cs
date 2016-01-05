using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.getinfo
{
    public class getinfoResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 相应person的姓名
        /// </summary>
        public string person_name { get; set; }
        /// <summary>
        /// 相应person的id
        /// </summary>
        public string person_id { get; set; }
        /// <summary>
        /// 包含的人脸列表
        /// </summary>
        public List<string> face_ids { get; set; }
        /// <summary>
        /// 包含此个体的组id
        /// </summary>
        public List<string> group_ids { get; set; }
    }
}
