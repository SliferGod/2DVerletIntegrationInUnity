using System;
using System.Collections.Generic;

public RadiusCollisions : VerletConstraint {

  public override void Constrain(List<VerletObjects> objects, float dt) {
    for(int a = 0; a < objects.Count; a++) {
      for(int b = 0; b < objects.Count; b++) {
        float dist = Vec2.distance(objects[a].position, objects[b].position);
        
        if(dist < objects[a].radius + objects[b].radius) {
            
        }
      }
    }
  }

}
