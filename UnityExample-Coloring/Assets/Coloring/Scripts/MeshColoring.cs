using UnityEngine;
using System.Collections;

public class MeshColoring : LoopSampleColor
{
	[SerializeField]
	MeshFilter meshFilter;

	Mesh mesh;
	Color[] colors;

	void Awake()
	{
		mesh = meshFilter.mesh;
		mesh.colors = new Color[mesh.vertexCount];
		colors = mesh.colors;
	}
	
	protected override void Update()
	{
		base.Update();

		Changecolor();
    }

	void Changecolor()
	{
		Color changeColor = Sample();
		
		for( int i=0; i<colors.Length; ++i )
		{
			colors[i] = changeColor;
        }

		mesh.colors = colors;
	}
}
