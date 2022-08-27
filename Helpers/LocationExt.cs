using CTeleportAssingment.Models;

namespace CTeleportAssingment.Helpers
{
    public static class LocationExt
    {
        public static double Distance(this Location l1, Location l2, GeometryHelper.Unit unit = GeometryHelper.Unit.Miles)
        {
            return GeometryHelper.Distance(l1.Latitude, l1.Longitude, l2.Latitude, l2.Longitude, unit);
        }
    }
}