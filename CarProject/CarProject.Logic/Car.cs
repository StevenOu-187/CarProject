namespace CarProject.Logic;

/// <summary>
/// Klasse Car repräsentiert ein Auto, das mit einem Gang und einer Geschwindigkeit arbeitet.
/// </summary>
/// <param name="dice"></param>
public class Car(IDice dice)
{
  #region fields
  private int
    _gear = 0,     // Der aktuelle Gang des Autos, Standard ist 0.
    _speed = 0;    // Die aktuelle Geschwindigkeit des Autos, Standard ist 0.

  private IDice
    _dice = dice;  // Ein Würfel-Objekt zur Simulation zufälliger Werte beim Beschleunigen.
  #endregion

  #region properties
  /// <summary>
  /// Öffentliche Eigenschaft für den Zugriff auf die Geschwindigkeit.
  /// </summary>
  public int Speed => _speed;

  /// <summary>
  /// Öffentliche Eigenschaft für den Gang mit Validierung.
  /// </summary>
  public int Gear
  {
    get => _gear;
    set
    {
      // Validierung: Gang muss zwischen 0 und 6 sein.
      if (value < 0 || value > 6)
        throw new ArgumentException("Gear should be between 0 and 6");
      else
        _gear = value;
    }
  }
  #endregion

  #region constructor
  /// <summary>
  /// Konstruktor ohne Parameter, verwendet einen Standard-Würfel (DefaultDice).
  /// </summary>
  public Car() : this(new DefaultDice()) { }
  #endregion

  #region method
  /// <summary>
  /// Methode zum Beschleunigen, basierend auf dem Gang und gewürfelten Augen.
  /// </summary>
  public void Accelerate()
  {
    _dice.Roll();                    // Würfelt, um eine zufällige Zahl zu generieren.
    _speed = Gear * 10 * _dice.Dots; // Berechnet die Geschwindigkeit: Gang * 10 * Würfel-Augen.
  }
  #endregion 

}