using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOnlyForceController : VerletForceController
{
    public VerletObject obj;
    public float gravityStrength;

    public GravityOnlyForceController(VerletObject obj, float gravityStrength)
    {
        this.obj = obj;
        this.gravityStrength = gravityStrength;
    }

    public GravityOnlyForceController(VerletObject obj)
    {
        this.obj = obj;
        gravityStrength = 1000;
    }

    public override void ApplyForces(float dt)
    {
        obj.acceleration += new Vec2(0, -gravityStrength * dt);
    }
}
