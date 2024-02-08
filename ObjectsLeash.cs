using System;
using System.Collections.Generic;

public class ObjectsLeash : VerletConstraint {
  public VerletObject objOne;
  public VerletObject objTwo;
  public float leashDistance;

  public ObjectsLeash(VerletObject objOne, VerletObject objTwo, float leashDistance) {
    this.objOne = objOne;
    this.objTwo = objTwo;
    this.leashDistance = leashDistance;
  }
  
  public override void Constrain(List<VerletObject> objects, float dt) {
    float distBetween = Vec2.distance(objOne.position, objTwo.position);

    if(distBetween > leashDistance) {
      Vec2 middlePoint = new Vec2((objOne.position.x + objTwo.position.x) / 2, (objOne.position.y + objTwo.position.y) / 2);
      float dist = distBetween / 2f;
      objOne.position = (.5f * leashDistance * ((objOne.position - middlePoint)) / dist) + middlePoint;
      objTwo.position = (.5f * leashDistance * ((objTwo.position - middlePoint)) / dist) + middlePoint;
    }
  }
}
