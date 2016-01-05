using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tencent.YoutuYun.Models.imagetag
{
    public class imagetagResponse : BaseResponse
    {
        /// <summary>
        /// 请求中的序列号
        /// </summary>
        public string seq { get; set; }
        /// <summary>
        /// 图像的分类标签
        /// </summary>
        public List<ImageTag> tags { get; set; }
    }
    public class ImageTag
    {
        /// <summary>
        /// 返回图像标签的名字
        /// </summary>
        public int tag_name { get; set; }
        /// <summary>
        /// 图像标签的置信度,整形范围 0-100,越大置信度越高
        /// </summary>
        public int tag_confidence { get; set; }
        /// <summary>
        /// 图像标签的置信度,浮点数范围 0-1,越大置信度越高
        /// </summary>
        public float tag_confidence_f { get; set; }

    }
}
