using BV.Campaingn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Application.UseCases.EventCampaingns.Create
{
    public sealed class GetEventsCampaingnResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal Budget { get; set; }
        public bool IsActive { get; set; }
        public string Tags { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
    }
}
