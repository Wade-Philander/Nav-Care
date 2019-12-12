using NavCareApi.Models;
using System.Linq;

namespace NavCareApi.Data
{
    public static class SeedData
    {
        public static void Initialize(NavCareApiContext context)
        {
            if (!context.MedicalFacilities.Any())
            {
                var facility = new MedicalFacility();

                facility.Description = "This is actually UWC";
                facility.FacilityName = "Uwc";
                facility.Latitude = "-33.933329";
                facility.Longitude = "18.6333308";

                context.MedicalFacilities.Add(facility);

                context.SaveChanges();
            }
        }
    }
}
