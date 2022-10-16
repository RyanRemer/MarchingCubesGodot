using System;
using Godot;

public class MarchingSurfaceTool : MarchingCubes
{
    public ArrayMesh Mesh;
    public SurfaceTool surfaceTool = new SurfaceTool();

    public override void AddTriangle(Triangle triangle)
    {
        GD.Print("ADD Triangle");
        surfaceTool.Begin(Godot.Mesh.PrimitiveType.Triangles);

        for (int i = 0; i < 3; i++){
            surfaceTool.AddVertex(triangle.Vertices[i]);
        }

        surfaceTool.GenerateNormals();

        Mesh = surfaceTool.Commit(Mesh);
    }
}