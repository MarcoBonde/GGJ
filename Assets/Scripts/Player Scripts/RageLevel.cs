using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RageLevel : MonoBehaviour
{
	[Tooltip("How long does it take for this slider to fill, in seconds")]
	public float FillTime = 1.0f;

	private Slider slider;
	void Start()
	{
		slider = GetComponent<Slider>();
		Reset();
	}

	public void Reset()
	{
		slider.minValue = Time.time;
		slider.maxValue = Time.time + FillTime;
	}
	void Update()
	{
		slider.value = Time.time;
	}

}
