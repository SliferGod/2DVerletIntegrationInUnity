using System;

public readonly struct Vec2 {
    public float x;
    public float y;

    public Vec2() {
        x = 0;
        y = 0;
    }

    public Vec2(float x, float y) {
        this.x = x;
        this.y = y;
    }

    public void setPosition(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public void setPosition(Vec2 v)
    {
        x = v.x;
        y = v.y;
    }

    public static Vec2 operator +(Vec2 a) => a;
    public static Vec2 operator -(Vec2 a) => new Vec2(-a.x, -a.y);

    public static Vec2 operator +(Vec2 a, Vec2 b)
        => new Vec2(a.x + b.x, a.y + b.y);

    public static Vec2 operator -(Vec2 a, Vec2 b)
        => a + (-b);

    public static Vec2 operator *(Vec2 a, Vec2 b)
        => new Vec2(a.x * b.x, a.y * b.y);

    public static Vec2 operator /(Vec2 a, Vec2 b)
    {
        if (b.x == 0 || b.y == 0)
        {
            throw new DivideByZeroException();
        }
        return new Vec2(a.x / b.x, a.y / b.y);
    }

    public static Vec2 operator ==(Vec2 a, Vec2 b) {
        if(a.x == b.x && a.y == b.y) return true;
        else return false;
    }

    public static Vec2 operator +(Vec2 a, float b)
        => new Vec2(a.x + b, a.y + b);

    public static Vec2 operator +(float a, Vec2 b)
        => new Vec2(b.x + a, b.y + a);
    
    public static Vec2 operator -(Vec2 a, float b)
        => a + (-b);

    public static Vec2 operator -(float a, Vec2 b)
        => a + (-b);

    public static Vec2 operator *(Vec2 a, float b)
        => new Vec2(a.x * b, a.y * b);

    public static Vec2 operator *(float a, Vec2 b)
        => new Vec2(a * b.x, a * b.y);

    public static Vec2 operator /(Vec2 a, Vec2 b)
    {
        if (b.x == 0 || b.y == 0)
        {
            throw new DivideByZeroException();
        }
        return new Vec2(a.x / b.x, a.y / b.y);
    }

    public static Vec2 operator /(float a, Vec2 b)
    {
        if (b.x == 0 || b.y == 0)
        {
            throw new DivideByZeroException();
        }
        return new Vec2(a / b.x, a / b.y);
    }

    public static Vec2 operator /(Vec2 a, float b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return new Vec2(a.x / b, a.y / b);
    }

    public static Vec2 operator ==(Vec2 a, Vec2 b) {
        if(a.x == b.x && a.y == b.y) return true;
        else return false;
    }

    public static float distance(Vec2 a, Vec2 b) {
        return Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
    }
}
