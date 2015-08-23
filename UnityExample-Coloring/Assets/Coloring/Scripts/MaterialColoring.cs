using UnityEngine;
using System.Collections;

public class MaterialColoring : LoopSampleColor
{
	[SerializeField]
	Renderer renderer;

	Material material;

	void Awake()
	{
		material = renderer.material;
	}

	void Update()
	{
		base.Update();

		material.color = Sample();
	}
}
