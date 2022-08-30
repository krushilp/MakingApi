using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MakingApi.Models
{
    public class fetchCarsList
    {

        public String carName { get; set; }
        public string carDesc { get; set; }
        public string carBrandName { get; set; }
        public string carUserName { get; set; }
        public int carUserID { get; set; }
        public string carUserCity { get; set; }
        public int carType { get; set; }
        public int carMPG { get; set; }

        public int carFuelType { get; set; }
        public int carGearBox { get; set; }
        public int carCapacity { get; set; }
        public int carYear { get; set; }
        public int carCondition { get; set; }
        public int carMileage { get; set; }
        public int carPrice { get; set; }
        public string carIsActive { get; set; }
        public string carViews { get; set; }
        public string carCreatedDate { get; set; }
        public string carVin { get; set; }
    }
}