using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models
{
    public class FaceItem
    {
        /// <summary>
        /// 人脸标识
        /// </summary>
        public string face_id { get; set; }
        //人脸框左上角x
        public int x { get; set; }
        /// <summary>
        /// 人脸框左上角y
        /// </summary>
        public int y { get; set; }
        /// <summary>
        /// 人脸框宽度
        /// </summary>
        public double width { get; set; }
        /// <summary>
        /// 人脸框高度
        /// </summary>
        public double height { get; set; }
        /// <summary>
        /// 性别 [0/(female)~100(male)]
        /// </summary>
        public double gender { get; set; }
        /// <summary>
        /// 年龄 [0~100]
        /// </summary>
        public double age { get; set; }
        /// <summary>
        /// 微笑[0(normal)~50(smile)~100(laugh)]
        /// </summary>
        public double expression { get; set; }
        /// <summary>
        /// 魅力 [0~100]
        /// </summary>
        public double beauty { get; set; }
        /// <summary>
        /// 是否有眼镜 [true,false]
        /// </summary>
        public bool glass { get; set; }
        /// <summary>
        /// 上下偏移[-30,30]
        /// </summary>
        public int pitch { get; set; }
        /// <summary>
        /// 左右偏移[-30,30]
        /// </summary>
        public int yaw { get; set; }
        /// <summary>
        /// 平面旋转[-180,180]
        /// </summary>
        public int roll { get; set; }

    }
}
