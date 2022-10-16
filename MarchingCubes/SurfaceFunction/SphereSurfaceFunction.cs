using Godot;
public class SphereSurfaceFunction : SurfaceFunction {
    private Vector3 Center;
    private float Radius;

    public SphereSurfaceFunction(Vector3 center, float radius)
    {
        Center = center;
        Radius = radius;
    }

    public override float calculate(float x, float y, float z)
    {
        float distance = Center.DistanceTo(new Vector3(x,y,z));
        return distance - Radius;
    }
}