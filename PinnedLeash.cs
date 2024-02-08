using System;
using System.Collections.Generic;

public class PinnedLeash : VerletConstraint
{
    unsafe public Vec2* pinPoint;
    public VerletObject obj;
    public float leashDistance;

    unsafe public PinnedLeash(Vec2 pinPoint, VerletObject obj, float leashDistance)
    {
        this.pinPoint = &pinPoint;
        this.obj = obj;
        this.leashDistance = leashDistance;
    }

    public override void Constrain(List<VerletObject> objects, float dt)
    {
        unsafe
        {
            float dist = Vec2.distance(*pinPoint, obj.position);

            if (dist > leashDistance)
            {
                obj.position = (leashDistance * ((obj.position - *pinPoint)) / dist) + *pinPoint;
            }
        }
    }
}
