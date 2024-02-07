using System;
using System.Collections.Generic;

public class PinnedLeash : VerletConstraint {
  public &Vec2 pinPoint;
  public VerletObject obj;

  public PinnedLeash(VerletObject obj) {
    this.obj = obj;
  }
  
  public void Constrain(List<VerletObject> objects, float dt) {
    
  }
}
