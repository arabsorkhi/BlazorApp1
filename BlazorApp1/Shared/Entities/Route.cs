using System;

namespace BlazorApp1.Shared.Entities
{
    public partial class Route
    {
        public long RouteId { get; set; }
        public Guid? Gid { get; set; }
        public long ServerId { get; set; }
        public int OrganizationId { get; set; }
        public bool AllowSend { get; set; }
        public bool AllowReceive { get; set; }
        public int? PathLength { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }

        public virtual Organizations Organization { get; set; }
        public virtual Server Server { get; set; }
    }
}
