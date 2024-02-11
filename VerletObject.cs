using System;

public class VerletObject {
    public Vec2 position;
    public Vec2 lastPosition;
    public Vec2 acceleration;
    public float radius;

    public VerletObject()
    {
        position = new Vec2(0, 0);
        lastPosition = new Vec2(0, 0);
        acceleration = new Vec2(0, 0);
        radius = 0;
    }

    public VerletObject(float x, float y)
    {
        position = new Vec2(x, y);
        lastPosition = new Vec2(x, y);
        acceleration = new Vec2(0, 0);
        radius = 0;
    }

    public VerletObject(float x, float y, float radius)
    {
        position = new Vec2(x, y);
        lastPosition = new Vec2(x, y);
        acceleration = new Vec2(0, 0);
        this.radius = radius;
    }

    public void UpdatePosition(float dt)
    {
        //Calculate the velocity using the Verlet method
        Vec2 velocity = position - lastPosition;
        //Save the current position as the old position since our position is about to change
        lastPosition = position;
        //Perform Verlet Integration
        position = position + velocity + acceleration * dt * dt;
        //Reset acceleration
        acceleration = new Vec2();
    }
}
