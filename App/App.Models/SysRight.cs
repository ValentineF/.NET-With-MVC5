//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SysRight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SysRight()
        {
            this.SysRightOperate = new HashSet<SysRightOperate>();
        }
    
        public string Id { get; set; }
        public string ModuleId { get; set; }
        public string RoleId { get; set; }
        public bool Rightflag { get; set; }
    
        public virtual SysModule SysModule { get; set; }
        public virtual SysRole SysRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SysRightOperate> SysRightOperate { get; set; }
    }
}
