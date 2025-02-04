namespace CarProject.Logic;

/// <summary>
/// Implementierung eines Würfels (Dice), der zufällige Werte zwischen 1 und 6 liefert.
/// </summary>
internal class DefaultDice : IDice
{
  #region field
  private readonly Random _random = new();
  #endregion

  #region property
  public int Dots { get; private set; }
  #endregion 

  #region method
  public void Roll() => Dots = _random.Next(1 , 7);



  #endregion

}