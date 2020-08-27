using System;
using System.Collections.Generic;

namespace BlazorApp1.Shared.Entities
{
    public partial class Server
    {
        public Server()
        {
            Route = new HashSet<Route>();
        }
        public long ServerId { get; set; }
        //ALTER TABLE[EXS].[Server] DROP COLUMN[GId];
        //ALTER TABLE[EXS].[Server]
        //ADD[GId] UNIQUEIDENTIFIER DEFAULT newid() NOT null
        public Guid Gid { get; set; }
        [Display(Name = "نام سرور")]
        public string Name { get; set; }
        [Display(Name = "آدرس")]
        public string Address { get; set; }
        [Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "وضعیت" ) ]
        public bool Status { get; set; }
        [Display(Name = "سرور پیش فرض")]
        public bool IsDefaultServer { get; set; }
        [Display(Name = "تاریخ ایجاد")]
        public DateTime CreationDateTime { get; set; }
        [Display(Name = "تاریخ اصلاح")]
        public DateTime? ModificationDateTime { get; set; }
        public virtual ICollection<Route> Route { get; set; }
    }
}
