using CarProject.Logic;

namespace CarProject.UnitTests;

[TestClass]
public class CarTests
{
  class FakeDice : IDice
  {
    #region properties
    public int Dots { get; set; } // Festgelegter Wert für Würfelaugen zur Kontrolle im Test
    public bool RollWasCalled { get; private set; } = false; // Flag, ob Roll() aufgerufen wurde
    #endregion properties

    #region methods
    public void Roll()
    {
      RollWasCalled = true; // Flag setzen, um zu prüfen, ob Roll() aufgerufen wurde
    }
    #endregion methods
  }

  [TestMethod]
  public void ItShouldStandStill_GivenCreated()
  {
    // ARRANGE - Erstellen eines neuen Autos
    Car car = new();

    // ACT - Abfrage der Anfangsgeschwindigkeit des Autos
    int actualSpeed = car.Speed;

    // ASSERT - Überprüfen, ob die Geschwindigkeit 0 ist
    Assert.AreEqual(0 , actualSpeed); // Erwartung: Geschwindigkeit ist 0.
  }

  [TestMethod]
  public void ItShouldStore_GivenGearBetweenOneAndSix()
  {
    // ARRANGE - Erstellen eines neuen Autos
    Car car = new()
    {
      // ACT - Setzen des Gangs auf einen gültigen Wert (z. B. 6)
      Gear = 6
    };

    // ASSERT - Überprüfen, ob der Gang korrekt gespeichert wurde
    Assert.AreEqual(6 , car.Gear); // Erwartung: Gang ist 6.
  }

  [TestMethod]
  [ExpectedException(typeof(ArgumentException) , "Gear should be between 0 and 6")]
  public void ItShouldThrowAnExpection_GivenGearOutsideRange()
  {
    // ARRANGE - Erstellen eines neuen Autos
    Car car = new()
    {
      // ACT - Setzen eines ungültigen Gangwerts (z. B. 7)
      Gear = 7 // Erwartung: ArgumentException.
    };

    // ASSERT - Überprüfung erfolgt durch das ExpectedException-Attribut
  }

  [TestMethod]
  public void ItShouldHaveASpeedOfZero_GivenNoAcceleration()
  {
    // ARRANGE - Erstellen eines neuen Autos und Setzen des Gangs
    Car car = new()
    {
      Gear = 3
    };

    // ACT - Keine Beschleunigung durchführen

    // ASSERT - Überprüfen, ob die Geschwindigkeit 0 ist
    Assert.IsTrue(car.Speed == 0); // Erwartung: Geschwindigkeit ist 0.
  }

  [TestMethod]
  public void ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated()
  {
    // ARRANGE - Erstellen eines neuen Autos und Setzen des Gangs
    Car car = new()
    {
      Gear = 3
    };

    // ACT - Beschleunigung durchführen
    car.Accelerate();

    // ASSERT - Überprüfen, ob die Geschwindigkeit im erwarteten Bereich liegt
    Assert.IsTrue(car.Speed >= 30 && car.Speed <= 180); // Erwartung: Geschwindigkeit zwischen 30 und 180.
  }

  [TestMethod]
  public void ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots()
  {
    // ARRANGE - Erstellen eines Autos mit einem FakeDice und Setzen des Gangs
    FakeDice fakeDice = new() { Dots = 2 }; // Setzt die Würfelaugen auf 2
    Car car = new(fakeDice)
    {
      Gear = 3
    };

    // ACT - Beschleunigung durchführen
    car.Accelerate();

    // ASSERT - Überprüfen, ob die Geschwindigkeit korrekt berechnet wurde (3 * 10 * 2 = 60)
    Assert.AreEqual(60 , car.Speed); // Erwartung: Geschwindigkeit ist 60.
  }

  [TestMethod]
  public void ItShouldCallDiceRoll_GivenAccelerateIsCalled()
  {
    // ARRANGE - Erstellen eines Autos mit einem FakeDice
    FakeDice fakeDice = new();
    Car car = new(fakeDice);

    // ACT - Beschleunigung durchführen
    car.Accelerate();

    // ASSERT - Überprüfen, ob Roll() aufgerufen wurde
    Assert.IsTrue(fakeDice.RollWasCalled); // Erwartung: Roll() wurde aufgerufen.
  }

}