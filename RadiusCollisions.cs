using System;
using System.Collections.Generic;

public RadiusCollisions : VerletConstraint {

  public override void Constrain(List<VerletObjects> objects, float dt) {
    for(int a = 0; a < objects.Count; a++) {
      for(int b = 0; b < objects.Count; b++) {
        float distBetween = Vec2.distance(objects[a].position, objects[b].position);
        
        if(distBetween < objects[a].radius + objects[b].radius) {
            VerletObject objOne = objects[a];
            VerletObject objTwo = objects[b];
          
            Vec2 middlePoint = new Vec2((objOne.position.x + objTwo.position.x) / 2, (objOne.position.y + objTwo.position.y) / 2);
            float dist = distBetween / 2f;
            objOne.position = (.5f * (objOne.radius + objTwo.radius) * ((objOne.position - middlePoint)) / dist) + middlePoint;
            objTwo.position = (.5f * (objOne.radius + objTwo.radius) * ((objTwo.position - middlePoint)) / dist) + middlePoint;
        }
      }
    }
  }

}
