using System;
using System.Collections.Generic;
using UnityEngine;

public class VerletSolver : MonoBehaviour
{
    [Header("Variables that Control the \nMain Settings of the Simulation")]
    public int numOfSubSteps;
    public float updateIntervalTime;
    public float leftOverTime;
    public float timeScale = 1;
    public List<VerletObject> objects = new List<VerletObject>();
    public List<VerletConstraint> constraints = new List<VerletConstraint>();
    public List<VerletForceController> forces = new List<VerletForceController>();
    

    public GameObject test;
    public VerletObject v;

    public GameObject testTwo;
    public VerletObject v2;

    public void Start()
    {
        v = new VerletObject(test.transform.position.x, test.transform.position.y, 1);
        objects.Add(v);

        PinnedLeash c = new PinnedLeash(new Vec2(-2, 0), v, 3);
        constraints.Add(c);

        GravityOnlyForceController f = new GravityOnlyForceController(v, 1000);
        forces.Add(f);



        v2 = new VerletObject(testTwo.transform.position.x, testTwo.transform.position.y, 1);
        objects.Add(v2);

        c = new PinnedLeash(new Vec2(-2, 0), v2, 3);
        constraints.Add(c);

        f = new GravityOnlyForceController(v2, 1000);
        forces.Add(f);

    }


    public void Update()
    {
        //Find the number of times we should run the simulation 
        int stepsToRun = (int)((Time.deltaTime + leftOverTime) / updateIntervalTime);
        //Solve the constraints and update verlet object positions
        for (int a = 0; a < stepsToRun; a++)
        {
            for (int b = 0; b < numOfSubSteps; b++)
            {
                //Run Constraints
                for (int c = 0; c < constraints.Count; c++) {
                    constraints[c].Constrain(objects, updateIntervalTime / numOfSubSteps);
                }

                //Apply Forces
                for (int c = 0; c < forces.Count; c++)
                {
                    forces[c].ApplyForces(updateIntervalTime / numOfSubSteps);
                }

                //Update the positions based on Verlet Integration
                for (int c = 0; c < objects.Count; c++)
                {
                    objects[c].UpdatePosition(updateIntervalTime / numOfSubSteps);
                }
            }
        }
        //Add the alloted time not left accounted for to the leftOverTime
        leftOverTime = (Time.deltaTime + leftOverTime) % updateIntervalTime;

        //Testing
        test.transform.position = new Vector3(v.position.x, v.position.y);
        testTwo.transform.position = new Vector3(v2.position.x, v2.position.y);
    }

}
