﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Garage2._0.Models
{
    public class CheckInMemberVehicleViewModel
    {
        public string? VehicleName { get; set; }

      //  public IEnumerable<SelectListItem> Vehicles  { get; set; } = new List<SelectListItem>();
        public int VehicleId { get; set; }
        public int MemberId { get; set; }


    }


}
