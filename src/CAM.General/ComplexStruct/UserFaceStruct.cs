
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 用户头像数据结构
    /// </summary>
    [Serializable]
    [ComplexType]
    public class UserFaceStruct
    {
        /// <summary>
        /// 头像URL地址
        /// </summary>
        [MaxLength(100)]
        public string Url { get; set; }

        public UserFaceStruct()
        {
            Url = "";
        }
    }
}
