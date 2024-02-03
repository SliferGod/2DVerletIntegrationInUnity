using System;

public class VerletObject {
    public Vec2 position;
    public Vec2 lastPosition;

    public void UpdatePosition(float dt)
    {
        //Calculate the velocity using the Verlet method
        Vec2 velocity = new Vec2(position.x - lastPosition.x, position.y - lastPosition.y);
        //Save the current position as the old position since our position is about to change
        lastPosition.setPosition(position);
        //Perform Verlet Integration
        
    }
}