using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.getfaceinfo
{
    public class getfaceinfoResponse : BaseResponse
    {
        /// <summary>
        /// 人脸信息
        /// </summary>
        public List<FaceItem> face_info { get; set; }
    }
}
