namespace CarProject.Logic;

public class FakeDice : IDice
{
  #region properties
  public int Dots { get; set; }

  public bool RollWasCalled { get; private set; } = false;
  #endregion

  #region method
  public void Roll() => RollWasCalled = true;
  #endregion

}