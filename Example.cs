using Godot;

public class Example : MeshInstance
{
    public override void _Ready()
    {
        Vector3 center = new Vector3(2f,2f,2f);
        float radius = 2f;
        SurfaceFunction surfaceFunction = new SphereSurfaceFunction(center, radius);   

        Vector3 position = Vector3.Zero;
        Vector3 size = new Vector3(8f,8f,8f);
        AABB box = new AABB(position, size);

        MarchingSurfaceTool marchingSurfaceTool = new MarchingSurfaceTool();
        float cellSize = 1f;
        marchingSurfaceTool.MarchAllCubes(box, cellSize, surfaceFunction);
        Mesh = marchingSurfaceTool.Mesh;
    }
}
