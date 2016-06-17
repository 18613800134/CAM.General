
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CAM.Common.Convert;

    /// <summary>
    /// 人员信息：姓名结构体，自动将姓名转换为拼音字母
    /// </summary>
    [Serializable]
    [ComplexType]
    public class UserNameStruct
    {
        private string _Name = "";

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(50)]
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NamePY = _Name.ToPinYinFirstChar();
                NameQP = _Name.ToPinYin();
            }
        }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(50)]
        public string NamePY { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(50)]
        public string NameQP { get; set; }

        public UserNameStruct()
        {
            Name = "";
            NamePY = "";
            NameQP = "";
        }
    }
}
