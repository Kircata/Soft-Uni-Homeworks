using System;
using System.Collections.Generic;
using System.Linq;
class NightLife
{
    static void Main()
    {
        var nightClubPerformances = new Dictionary<string, SortedDictionary<string, SortedSet<string>>> { };
        string[] cityVenuePerformer = Console.ReadLine().Split(';').ToArray();
        while (cityVenuePerformer[0] != "END")
        {          
            string city = cityVenuePerformer[0];
            string venue = cityVenuePerformer[1];
            string performer = cityVenuePerformer[2];
            if (!nightClubPerformances.ContainsKey(city))
            {
                nightClubPerformances[city] = new SortedDictionary<string, SortedSet<string>>();
            }
            if (!nightClubPerformances[city].ContainsKey(venue))
            {
                nightClubPerformances[city][venue] = new SortedSet<string>();
            }
            if (!nightClubPerformances[city][venue].Contains(performer))
            {
                nightClubPerformances[city][venue].Add(performer);
            }
            cityVenuePerformer = Console.ReadLine().Split(';').ToArray();
        }


        foreach (var cityVenue in nightClubPerformances)
        {
            Console.WriteLine("{0}", cityVenue.Key);

            foreach (var venuePerformers in cityVenue.Value)
            {
                Console.WriteLine("->{0}: {1}", venuePerformers.Key, string.Join(", ", venuePerformers.Value));
            }
        }

    }
}

