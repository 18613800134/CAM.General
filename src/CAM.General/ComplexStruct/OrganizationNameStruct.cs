
namespace CAM.General.ComplexStruct
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CAM.Common.Convert;

    /// <summary>
    /// 组织机构名称结构信息：包含全称、拼音、简称
    /// </summary>
    [Serializable]
    [ComplexType]
    public class OrganizationNameStruct
    {
        private string _Name = "";

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(100)]
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
        [MaxLength(100)]
        public string NamePY { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(100)]
        public string NameQP { get; set; }

        [Index(IsClustered = false, IsUnique = false)]
        [MaxLength(20)]
        public string NameShort { get; set; }

        public OrganizationNameStruct()
        {
            Name = "";
            NamePY = "";
            NameQP = "";
            NameShort = "";
        }
    }
}
