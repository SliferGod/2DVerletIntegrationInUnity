using System.Collections;
using System.Collections.Generic;

public abstract class VerletConstraint
{
    public abstract void Constrain(List<VerletObject> objects, float dt);
}
