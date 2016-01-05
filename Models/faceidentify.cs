using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models
{
    public class faceidentifyResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 识别出的top5候选人
        /// </summary>
        public List<IdentifyItem> candidates { get; set; }
    }
    public class IdentifyItem
    {
        /// <summary>
        /// 候选者person_id
        /// </summary>
        public string person_id { get; set; }
        /// <summary>
        /// 候选者face_id
        /// </summary>
        public string face_id { get; set; }
        /// <summary>
        /// 候选者的置信度
        /// </summary>
        public float confidence { get; set; }
        /// <summary>
        /// 人脸备注信息
        /// </summary>
        public string tag { get; set; }
    }
}
