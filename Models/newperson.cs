using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.newperson
{
    public class newpersonResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 成功被加入的group数量
        /// </summary>
        public int suc_group { get; set; }
        /// <summary>
        /// 成功加入的face数量
        /// </summary>
        public int suc_face { get; set; }
        /// <summary>
        /// 相应person的id
        /// </summary>
        public string person_id { get; set; }
        /// <summary>
        /// 创建所用图片生成的face_id
        /// </summary>
        public string face_id { get; set; }
        /// <summary>
        /// 加入成功的组id
        /// </summary>
        public List<string> group_ids { get; set; }

    }
}
