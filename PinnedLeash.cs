using System;
using System.Collections.Generic;

public class PinnedLeash : VerletConstraint {
  public &Vec2 pinPoint;
  public VerletObject obj;
  public float leashDistance;

  public PinnedLeash(&Vec2 pinPoint, VerletObject obj, float leashDistance) {
    this.pinPoint = pinPoint;
    this.obj = obj;
    this.leashDistance = leashDistance;
  }
  
  public void Constrain(List<VerletObject> objects, float dt) {
    float dist = Vec2.distance(pinPoint, obj.position);

    if(dist > leashDistance) {
      obj.position = (leashDistance * ((obj.position - pinPoint)) / dist) + pinPoint;
    }
  }
}
