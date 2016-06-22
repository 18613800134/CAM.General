
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 常用联系方式结构体
    /// 修改
    /// </summary>
    [Serializable]
    [ComplexType]
    public class ContactStruct
    {
        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(100)]
        public string EMail { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(20)]
        public string QQ { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(50)]
        public string WeiXin { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(20)]
        public string MobileNo { get; set; }


        public ContactStruct()
        {
            EMail = "";
            QQ = "";
            WeiXin = "";
            MobileNo = "";
        }
    }
}
