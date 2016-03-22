namespace _1.GalacticGPS.Models
{

    using System;
    using Interfaces;

    struct Location  : ILocation
    {

        private const short LatitudeMaxRange = 90;
        private const short LatitudeMinRange = -90;
        private const short LongitudeMaxRange = 180;
        private const short LongitudeMinRange = -180;
        private double latitude;
        private double longitude;

        public Location(double latitude, double longitude, Planet planet) 
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PlanetType = planet;
        }


        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value < LatitudeMinRange || value > LatitudeMaxRange)
                {
                    throw new ArgumentOutOfRangeException("The latitude must be in the range of [-90...90]");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value < LongitudeMinRange || value > LongitudeMaxRange)
                {
                    throw new ArgumentOutOfRangeException("The longitude must be in the range of [-180...180]");
                }
                this.longitude = value;
            }
        }

        public Planet PlanetType { get; set; }

        public override string ToString()
        {
            return string.Format("{0} , {1} - {2}", this.Latitude, this.Longitude, this.PlanetType);
        }
    }
}
