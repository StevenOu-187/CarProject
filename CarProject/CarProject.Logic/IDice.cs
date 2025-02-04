namespace CarProject.Logic;

/// <summary>
/// Interface für einen Würfel (Dice) mit den grundlegenden Methoden und Eigenschaften.
/// </summary>
public interface IDice
{
  #region properties
  public int Dots { get; }
  #endregion

  #region public methods
  public void Roll();
  #endregion

}