using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracio.Data.Models.RouteModel
{
    public class CreateRouteModel
    {
        public int? CreatorId { get; set; }

        public string? StartLocation { get; set; }

        public string? EndLocation { get; set; }

        public double? Distance { get; set; }

        public double? EstimatedTime { get; set; }

        public string? RouteDescription { get; set; }

        public bool? SharedWithPublic { get; set; }

        public DateTime? CreatedTime { get; set; } = DateTime.Now;

        public string? RoutePath { get; set; }

        public string? SegmentPolyline { get; set; }

        public string? StreetList { get; set; }

        public string? Status { get; set; } = "Active";


    }
}
