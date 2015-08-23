using UnityEngine;
using System.Collections;

public class LoopSampleColor : MonoBehaviour
{
	#region Gradient
	[SerializeField]
	Gradient color;
	#endregion

	[SerializeField]
	[Range(0.001f,5.0f)]
	float duration;

	float curTime=0.0f;

	public Color Sample()
	{
		return color.Evaluate( curTime/duration );
	}

	#region Update Animation time
	protected void Update()
	{
		if( curTime < duration )
		{
			curTime+=Time.deltaTime;
		}
		else
		{
			TrimTime();
		}
	}

	void TrimTime()
	{
		curTime -= duration;
	}
	#endregion
}
