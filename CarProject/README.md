###### <p align="center"> CarProject - Documentation </p>

#### [Test Driven Development - My Protocol](https://github.com/IxI-Enki/car-race-project-fork/blob/main/TDD_Car_Project_Tests.md)

---
- # 1.) Overview  
  *The **CarProject** project simulates a car model that takes speed and gear into account and includes random components in acceleration via a cube interface.*  
  *The logic includes several **classes** such as **Car**, **DefaultDice**, **Section**, **Track**, **TrackBuilder** as well as associated **Unit-tests** that check the behavior of the car.*  

---
- # 2.) Explanation of the Classes and Interfaces  

- ## 2.1) Class Car  
  *The 'Car' class represents the car with the following main characteristics*:  
  - ***`_gear`***: A private field that stores the current gear of the car.  `Default is 0`
  - ***`_speed`***: A private field that stores the speed of the car.  `Default is 0`
  - ***`_dice`***: A dice object (of type 'IDice') that provides random values ​​to influence speed.  
  - ***`Gear` property***: has validation that ensures that only values ​​between 0 and 6 are accepted.	
  - ***`Accelerate()`***: rolls a dice and calculates the speed based on the current gear and the eyes rolled.

- ## 2.2) Interface IDice  
  *The 'IDice' interface defines the structure of a cube used in this project*.  
  *It contains the properties and methods necessary for the cube implementations*:  
  - ***`Dots`***: A property that represents the number of dots rolled.  
  - ***`Roll()`***: A method that rolls the dice and sets a new random number.  

- ## 2.3) Class DefaultDice  
  *The 'DefaultDice' class implements the 'IDice' interface and uses a random generator to roll a number between 1 and 6.*  
  - ***`Dots` property***: stores the result.  
    > This allows you to control the dice roll and realistically simulate the behavior of the car.  

- ## 2.4) Class Section  
  *The 'Section' class represents a road section that is described by the maximum permitted speed (`MaxSpeed`) and the `Length` of the section.*   
    > This allows a realistic simulation of various road conditions and restrictions.  

---
- # 3.) Unit testing  
  *Unit tests validate the behavior of classes and methods and ensure that requirements are met.*  
    The main tests are as follows:  

- ## 3.1) Car Tests  
  *Check the tests for the 'Car' class:*  
  - ***Initial values*** ​​such as `Speed` and `Gear` when creating a car.
  - ***Validation of `gears`*** between 0 and 6 as well as exception handling for invalid values.
  - ***Acceleration logic*** by using a `FakeDice` to test the speed based on a known value.

- ## 3.2) SectionTests  
  *This tests ensures that the Section class correctly stores and initializes the `MaxSpeed` ​​and `Length` attributes.*

---
- # 4.) Test expansion options   
  *There are several ways to further extend the tests and examine additional scenarios:*  
  - ***Negative tests*** for 'Accelerate()' to catch invalid conditions such as negative `Speed`.  
  - ***Compliance with*** `MaxSpeed` ​​constraints in the 'Section' class to test whether the auto speed respects the section boundaries.  
  - ***Check error messages*** for invalid `Gear` values ​​to ensure that the expected exceptions are thrown correctly.  

----

<div align="center">
 
| ***Step/Aspect***       | ***With DefaultDice***                | ***With FakeDice***                                | 
| :---------------------: | ------------------------------------: | :------------------------------------------------- |   
| Creating the Car object | DefaultDice is used automatically     | FakeDice is passed explicitly                      | 
| Calling Roll()          | Generates a random number for Dots    | Just sets RollWasCalled to true                    | 
| Calculation of speed    | Speed ​​varies based on dots            | Speed ​​is constant (e.g. Dots = 2)                  |
| Results in the test     | Speed ​​depends on random dots          | Speed ​​is predictable, RollWasCalled is verifiable  |
| Dots                    | Random value between 1 and 6          | Fixed value for controlled testing                 |
| Roll() behavior         | Generates and sets random dots value  | Sets RollWasCalled to true, Dots remains unchanged |

</div>
