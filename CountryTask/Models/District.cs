using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryTask.Models
{
    public class District
    {
        public string StateName { get; set; }
        public string DistrictName { get; set; }

        public static IQueryable<District> GetDistrict()
        {
            return new List<District>
        {
            new District { StateName = "Bihar", DistrictName = "Motihari" },
            new District { StateName = "Bihar", DistrictName = "Muzaffarpur" },
            new District { StateName = "Bihar", DistrictName = "Patna" },
            new District { StateName = "Jharkhand", DistrictName = "Bokaro" },
            new District { StateName = "Jharkhand", DistrictName = "Ranchi" },
        }.AsQueryable();
        }
    }
}
