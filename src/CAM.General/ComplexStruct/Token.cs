
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 保持用户身份所使用的Token令牌结构
    /// 多条Token值可以确保用户在不同终端同时登陆
    /// </summary>
    [Serializable]
    [ComplexType]
    public class Token
    {
        [Index(IsClustered = false, IsUnique = false)]
        public Guid PC { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        public Guid MobileIOS { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        public Guid MobileAndroid { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        public Guid PadIOS { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        public Guid PadAndroid { get; set; }

        public Token()
        {
            PC = Guid.NewGuid();
            MobileIOS = Guid.NewGuid();
            MobileAndroid = Guid.NewGuid();
            PadIOS = Guid.NewGuid();
            PadAndroid = Guid.NewGuid();
        }
    }
}
