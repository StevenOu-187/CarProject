namespace CarProject.Logic;

public class TrackBuilder
{
  #region field
  private readonly (int, int)[ ] _sectionInfos;
  private readonly Track? _track;
  #endregion

  #region property
  public Track? RaceTrack => _track;
  #endregion

  #region constructor
  public TrackBuilder((int, int)[ ] sectionInfos , bool trackShallLoop = false)
  {
    _sectionInfos = sectionInfos;

    List<Section> allSections = [ ];
    Section? lastSection = null;

    foreach (var section in _sectionInfos)
    {
      Section newSection = new(section.Item1 , section.Item2);

      if (allSections.Count > 0)
        lastSection!.AddAfterMe(newSection);

      lastSection = newSection;
      allSections.Add(newSection);
    }

    _track = new Track(allSections , trackShallLoop);
  }
  #endregion
}
