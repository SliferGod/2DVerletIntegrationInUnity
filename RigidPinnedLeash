using System;
using System.Collections.Generic;

public class RigidPinnedLeash : VerletConstraint {
  public &Vec2 pinPoint;
  public VerletObject obj;
  public float leashDistance;

  public RigidPinnedLeash(&Vec2 pinPoint, VerletObject obj, float leashDistance) {
    this.pinPoint = pinPoint;
    this.obj = obj;
    this.leashDistance = leashDistance;
  }
  
  public void Constrain(List<VerletObject> objects, float dt) {
    float dist = Vec2.distance(pinPoint, obj.position);

    if(dist != leashDistance && dist != 0) {
      obj.position = (leashDistance * ((obj.position - pinPoint)) / dist) + pinPoint;
    }
  }
}
