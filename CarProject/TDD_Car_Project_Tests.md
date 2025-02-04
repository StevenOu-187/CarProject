###### <p align="center"> Test-Driven Development (TDD) for Car and Track Project </p>
---
*This document contains an overview of the important tests for the Car, Section and Track classes as part of a Test-Driven Development (TDD) approach.*  
*Each test was written first and then the code was adjusted so that all tests were successful.*  

---
- # 1.) Important Additional Tests
  *To further validate the robustness and functionality of the program, the following tests can be implemented:*
  - ***Gear Transition Speed ​​Test***:
    > Checks whether the speed resets or adjusts correctly when the gear changes from high to low.
  - ***Test for consistency of the dice value***:
    > Checks whether rolling the dice always results in a number between 1 and 6 and that there are no exceptions or unexpected values.
  - ***Section Maximum Speed ​​Test***:
    > Verify that the car's speed does not exceed the maximum speed of a section.
  - ***Test for gear change exception***:
    > Checks whether ArgumentException is thrown correctly when invalid gear values ​​(e.g. above 6) are set.
  - ***Speed ​​test after multiple accelerations without changing gear***:
    > Checks whether the speed behaves consistently when 'Accelerate' is called up several times.

---
- # 2.) Tests for the Car class
   
  - ### ***ItShouldStandStill_GivenCreated***:
    > Ensures that the `Speed` of the car is 0, when created.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldStandStill_GivenCreated" src="./img/ItShouldStandStill_GivenCreated.png" width=80%>
      </details>
   
  - ### ***ItShouldStore_GivenGearBetweenOneAndSix***:
    > Ensures that a valid `Gear` is stored as expected.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldStore_GivenGearBetweenOneAndSix" src="./img/ItShouldStore_GivenGearBetweenOneAndSix.png" width=80%>
      </details>
 
  - ### ***ItShouldThrowAnExpection_GivenGearOutsideRange***: 
    > Ensures that a `ExpectedException(typeof(ArgumentException)` is thrown, if an invalid `Gear` was set.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldThrowAnExpection_GivenGearOutsideRange" src="./img/ItShouldThrowAnExpection_GivenGearOutsideRange.png" width=80%>
      </details>

  - ### ***ItShouldHaveASpeedOfZero_GivenNoAcceleration***: 
    > Ensures that the `Speed` of a car is 0, if not accelerated.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldHaveASpeedOfZero_GivenNoAcceleration" src="./img/ItShouldHaveASpeedOfZero_GivenNoAcceleration.png" width=80%>
      </details>

  - ### ***ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated***: 
    > Ensures that `Accelerate()` works as intended, if a valid `Gear` was chosen and the new `Speed` of the car is in a valid range.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated" src="./img/ItShouldHaveASpeedBetween30And180_GivenGear3AndAccelerated.png" width=80%>
      </details>

  - ### ***ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots***: 
    > Ensures that the Acceleration and `Speed` was computed correctly.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots" src="./img/ItShouldHaveASpeedOf60_GivenGear3AndDiceShowsTwoDots.png" width=80%>
      </details>
   
  - ### ***ItShouldCallDiceRoll_GivenAccelerateIsCalled***: 
    > Ensures that `Dice.RollWasCalled` is `true` if the car has accelerated.
      <details> <summary> $\color{lightgreen}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldCallDiceRoll_GivenAccelerateIsCalled" src="./img/ItShouldCallDiceRoll_GivenAccelerateIsCalled.png" width=80%>
      </details>
 
---
- # 3.) Tests for the Section class
  
  - ### ***ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated***:
    > Ensures that `MaxSpeed` ​​and `Length` are set correctly.
      <details> <summary> $\color{green}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated" src="./img/ItShouldHaveALengthAndAMaxSpeed_GivenObjectCreated.png" width=80%>
      </details>

  - ### ***ItShouldConnectASectionAfterTheCurrentSection_GivenAddAfterMeIsCalled***:
    > Ensures that connecting Sections with `AddAfterMe()` works as expected.
      <details> <summary> $\color{green}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldConnectASectionAfterTheCurrentSection_GivenAddAfterMeIsCalled" src="./img/ItShouldConnectASectionAfterTheCurrentSection_GivenAddAfterMeIsCalled.png" width=80%>
      </details>

   - ### ***ItShouldConnectASectionBeforeTheCurrentSection_GivenAddBeforeMeIsCalled***:
     > Ensures that connecting Sections with `AddBeforeMe()` works as expected.
       <details> <summary> $\color{green}{click\ for\ Screenshot}$ </summary>

        <img alt="ItShouldConnectASectionBeforeTheCurrentSection_GivenAddBeforeMeIsCalled" src="./img/ItShouldConnectASectionBeforeTheCurrentSection_GivenAddBeforeMeIsCalled.png" width=80%>
      </details>

    - ### ***ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddAfterMeIsCalled***:
      > Ensures that connecting Sections with `AddAfterMe()` reconnects given Sections as expected.
       <details> <summary> $\color{green}{click\ for\ Screenshot}$ </summary>

        <img alt="ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddAfterMeIsCalled" src="./img/ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddAfterMeIsCalled.png" width=80%>
      </details>

    - ### ***ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddbeforeMeIsCalled***:
      > Ensures that connecting Sections with `AddBeforeMe()` reconnects given Sections as expected.
        <details> <summary> $\color{green}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddbeforeMeIsCalled" src="./img/ItShouldInsertASectionBetweenTwoSections_GivenTwoConnectedSectionsAndAddbeforeMeIsCalled.png" width=80%>
        </details>
    
 - ## 3.1) Additional tests for Section
    - ***ItShouldThrowException_GivenNegativeMaxSpeed***:
      > Checks whether negative MaxSpeed ​​values ​​throw an exception.
     
    - ***ItShouldThrowException_GivenNegativeLength***:
      > Checks whether negative length values ​​throw an exception.
      
    - *Minimum Length Test* (***ItShouldThrowException_GivenLengthLessThanMinimum***):
      > Tests whether an exception is thrown if Length is too low.
      
    - *Limit for MaxSpeed* ​​(***ItShouldThrowException_GivenMaxSpeedExceedsLimit***):
      > Checks whether MaxSpeed ​​does not exceed the limit.


---
- # 4.) Tests for the Track class
    - ### ***ItShouldSaveTheStartSectionOfATrack_GivenAnyNumbersOfSections***:
      > Ensures that the `StartSection` gets saved by the track, as expected.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldSaveTheStartSectionOfATrack_GivenAnyNumbersOfSections" src="./img/ItShouldSaveTheStartSectionOfATrack_GivenAnyNumbersOfSections.png" width=80%>
         </details>

 - ## 4.1) Additional tests for Track 
      *If a track class contains multiple section instances, the following tests may be useful:*
 
    - ### ***ItShouldReturnTotalLength_GivenMultipleSections***:
      > Checks whether `GetTotalLength` calculates the correct total length of the sections.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldReturnTotalLength_GivenMultipleSections" src="./img/ItShouldReturnTotalLength_GivenMultipleSections.png" width=80%>
         </details>
      
    - ### ***ItShouldReturnMaxSpeed_GivenMultipleSections***:
      > Checks whether `GetMaxSpeed` returns the highest allowed speed in the track.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldReturnMaxSpeed_GivenMultipleSections" src="./img/ItShouldReturnMaxSpeed_GivenMultipleSections.png" width=80%>
         </details>
      
    - ### ***ItShouldThrowException_GivenEmptySectionList***:
      > Ensure an `exception is thrown` when track is created without sections.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldThrowException_GivenEmptySectionList" src="./img/ItShouldThrowException_GivenEmptySectionList.png" width=80%>
         </details>
      
    - ### ***ItShouldThrowException_GivenNullSectionInList***:
      > Checks whether no `null` objects are accepted as a section.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldThrowException_GivenNullSectionList" src="./img/ItShouldThrowException_GivenNullSectionList.png" width=80%>
         </details>
         
    - ### ***ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack***:
      > Checks if a track is a looped track or not.
        <details> <summary> $\color{lime}{click\ for\ Screenshot}$ </summary>

         <img alt="ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack" src="./img/ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack.png" width=80%>
        </details>
        
---
- # 5.) Tests for the TrackBuilder class
  
  - ### ***ItShouldBuildAConnectedTrack_GivenSectionInformation***:
    > Checks if the TrackBuilder builds (connects) a Track with given Sections as expected.
      <details> <summary> $\color{yellow}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldBuildAConnectedTrack_GivenSectionInformation" src="./img/ItShouldBuildAConnectedTrack_GivenSectionInformation.png" width=80%>
      </details>

  - ### ***ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack***:
    > Checks if a track is a looped track or not.
      <details> <summary> $\color{yellow}{click\ for\ Screenshot}$ </summary>

       <img alt="ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack_Trackbuilder" src="./img/ItShouldConnectTheLastSegmentToTheFirst_GivenAnAdditionalParameterForALoopedTrack_Trackbuilder.png" width=80%>
      </details>

--- 
- # 6.) Summary
  *These tests cover the most important requirements and error conditions of the Car, Section and Track classes.*  
  *They validate the basic logic and robustness of the program and ensure that the application remains stable even with invalid inputs.*
