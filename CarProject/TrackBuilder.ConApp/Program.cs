using CarProject.Logic;

namespace TrackBuilder.ConApp;

internal class Program
{
  static void Main()
  {
    (int, int)[ ] sectionInfos = [ (100, 10) , (200, 20) , (300, 30) ];

    CarProject.Logic.TrackBuilder builder = new(sectionInfos);
    Track raceTrack = builder.RaceTrack!;

    Console.WriteLine("Prints all sections: ");
    raceTrack.Debug_PrintSection(-1);

    Console.Write("\nStart Section :\n");
    raceTrack.Debug_PrintSection(0);
    Console.Write("\nSection 2:\n");
    raceTrack.Debug_PrintSection(1);
    Console.Write("\nSection 3:\n");
    raceTrack.Debug_PrintSection(2);
  }
}
