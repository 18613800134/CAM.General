
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 常用第三方授权平台返回的用户或设备ID
    /// </summary>
    [Serializable]
    [ComplexType]
    public class EXTPlugInForPassport
    {
        /// <summary>
        /// QQ验证返回用户ID，唯一的
        /// </summary>
        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(100)]
        public string QQUserId { get; set; }

        /// <summary>
        /// 微信验证返回用户ID，唯一的
        /// </summary>
        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(100)]
        public string WeiXinUserId { get; set; }

        /// <summary>
        /// 极光推送用户机器ID，每个机器都是唯一的
        /// 用户在不同设备上登陆，这个ID是不同的
        /// </summary>
        [MaxLength(50)]
        public string JPushId { get; set; }

        public EXTPlugInForPassport()
        {
            QQUserId = "";
            WeiXinUserId = "";
            JPushId = "";
        }
    }
}
