using System;
using System.Collections.Generic;

public class PinnedLeash : VerletConstraint {
  public VerletObject objOne;
  public VerletObject objTwo;
  public float leashDistance;

  public PinnedLeash(VerletObject obj) {
    this.obj = obj;
  }
  
  public void Constrain(List<VerletObject> objects, float dt) {
    float dist = Vec2.distance(pinPoint, obj.position);

    if(dist != leashDistance) {
      obj.position = new Vec2(leashDistance * (obj.position.x / dist), leashDistance * (obj.position.y / dist));
    }
  }
}
