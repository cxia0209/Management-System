//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infrastructure.Data.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class genreDirector
    {
        public string genre_id { get; set; }
        public string director_id { get; set; }
        public string description { get; set; }
    
        public virtual genre genre { get; set; }
    }
}