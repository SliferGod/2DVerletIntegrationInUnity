using System;

public class VerletObject {
    public Vec2 position;
    public Vec2 lastPosition;
    public Vec2 acceleration;

    public void UpdatePosition(float dt)
    {
        //Calculate the velocity using the Verlet method
        Vec2 velocity = position - lastPosition;
        //Save the current position as the old position since our position is about to change
        lastPosition = position;
        //Perform Verlet Integration
        position = position + velocity + acceleration * dt * dt;
    }
}
