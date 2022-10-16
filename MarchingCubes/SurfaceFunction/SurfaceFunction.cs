public abstract class SurfaceFunction {
    // Gets the distance from the surface of a given point
    // positive is outside the shape
    // 0 is the surface
    // negative is inside the shape
    public abstract float calculate(float x, float y, float z);
}