using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.detectface
{
    public class detectfaceResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 系统中的图片标识符，用于标识用户请求中的图片
        /// </summary>
        public string image_id { get; set; }
        /// <summary>
        /// 请求图片的高度
        /// </summary>
        public double image_height { get; set; }
        /// <summary>
        /// 请求图片的宽度
        /// </summary>
        public double image_width { get; set; }
        /// <summary>
        /// 被检测出的人脸FaceItem的列表
        /// </summary>
        public List<FaceItem> face { get; set; }
    }
    
}
