using UnityEngine;
using System.Collections;

public class MaterialColoring : LoopSampleColor
{
	[SerializeField]
	Renderer meshRenderer;

	Material material;

	void Awake()
	{
		material = meshRenderer.material;
	}
	
	protected override void Update()
	{
		base.Update();

		material.color = Sample();
	}
}
