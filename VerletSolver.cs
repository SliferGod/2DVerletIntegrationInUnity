using System;
using UnityEngine;

public class VerletSolver {
  public int numOfSubSteps;
  public float updateIntervalTime;
  public float leftOverTime;
  public VerletObject[] objects;
  public float timeScale = 1;

  public void Update() {
    //Find the number of times we should run the simulation 
    int stepsToRun = int((Time.deltaTime + leftOverTime) / updateIntervalTime);
    //Solve the constraints and update verlet object positions
    for(int a = 0; a < stepsToRun; a++) {
      for(int b = 0; b < numOfSubSteps; b++) {
        for(int c = 0; c < objects.length; c++) {
          objects[c].updatePosition(updateIntervalTime / numOfSubSteps);
        }
      }
    }
    //Add the alloted time not left accounted for to the leftOverTime
    leftOverTime = (Time.deltaTime + leftOverTime) % updateIntervalTime;
  }
  
}
