namespace _1.GalacticGPS.Interfaces
{
    interface ILocation
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
        Planet PlanetType { get; set; }
    }
}
