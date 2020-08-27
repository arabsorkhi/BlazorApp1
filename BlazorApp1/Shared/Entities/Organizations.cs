using System.Collections.Generic;

namespace BlazorApp1.Shared.Entities
{
    public partial class Organizations
    {
        public Organizations()
        {
            Route = new HashSet<Route>();
        }

        public int OrganizationId { get; set; }
        public int? ParentId { get; set; }
        [Display(Name = "نام سازمان")]
        public string Name { get; set; }
        public int Code { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Route> Route { get; set; }
    }
}
