using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.faceshape
{
    public class faceshapeResponse : BaseResponse
    {
        /// <summary>
        /// 相应请求的session标识符，可用于结果查询
        /// </summary>
        public string session_id { get; set; }
        /// <summary>
        /// 请求图片的高度
        /// </summary>
        public double image_height { get; set; }
        /// <summary>
        /// 请求图片的宽度
        /// </summary>
        public double image_width { get; set; }
        /// <summary>
        /// 人脸轮廓结构体，包含所有人脸的轮廓点(以防万一，这里先用泛型)
        /// </summary>
        public List<Face_Shape> face_shape { get; set; }
    }

    public class Face_Shape
    {
        /// <summary>
        /// 描述脸型轮廓的21点
        /// </summary>
        public List<FacePoint> face_profile { get; set; }
        /// <summary>
        /// 描述左眼轮廓的8点
        /// </summary>
        public List<FacePoint> left_eye { get; set; }
        /// <summary>
        /// 描述右眼轮廓的8点
        /// </summary>
        public List<FacePoint> right_eye { get; set; }
        /// <summary>
        /// 描述左眉轮廓的8点
        /// </summary>
        public List<FacePoint> left_eyebrow { get; set; }
        /// <summary>
        /// 描述右眉轮廓的8点
        /// </summary>
        public List<FacePoint> right_eyebrow { get; set; }
        /// <summary>
        /// 描述嘴巴轮廓的22点
        /// </summary>
        public List<FacePoint> mouth { get; set; }
        /// <summary>
        /// 描述鼻子轮廓的13点
        /// </summary>
        public List<FacePoint> nose { get; set; }
    }
    public class FacePoint
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
