using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VerletForceController : MonoBehaviour
{
    public abstract void ApplyForces(float dt);
}
