using System;
using UnityEngine;

public class VerletSolver : MonoBehaviour
{
    public int numOfSubSteps;
    public float updateIntervalTime;
    public float leftOverTime;
    public VerletObject[] objects;
    public float timeScale = 1;

    public GameObject test;
    public VerletObject v;

    public void Start()
    {
        v = new VerletObject(test.transform.position.x, test.transform.position.y);
        objects = new VerletObject[1];
        objects[0] = v;
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
                for (int c = 0; c < objects.Length; c++)
                {
                    objects[c].acceleration += new Vec2(0, -10);
                    objects[c].UpdatePosition(updateIntervalTime / numOfSubSteps);

                    float dist = Vec2.distance(objects[c].position, new Vec2(0, 0));
                    if (dist > 3f)
                    {
                        objects[c].position = objects[c].lastPosition;
                    }
                }
            }
        }
        //Add the alloted time not left accounted for to the leftOverTime
        leftOverTime = (Time.deltaTime + leftOverTime) % updateIntervalTime;

        //Testing
        test.transform.position = new Vector3(v.position.x, v.position.y);
    }

}
