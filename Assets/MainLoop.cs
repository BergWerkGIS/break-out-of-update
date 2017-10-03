using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLoop : MonoBehaviour
{

	private bool _firstUpdate = true;
	private HeavyDutyWorker _hdWorker;

	void Start()
	{
		_hdWorker = new HeavyDutyWorker();
	}



	// Update is called once per frame
	void Update()
	{

		if (_firstUpdate)
		{
			_firstUpdate = false;

			//those 3 together take around 5 to 6 secs on my laptop
			Debug.Log("30: " + SimulateTileCreation.NthFibonacciNumber(30));
			Debug.Log("35: " + SimulateTileCreation.NthFibonacciNumber(35));
			Debug.Log("40: " + SimulateTileCreation.NthFibonacciNumber(40));

			//_hdWorker.StartWorking(() =>
			//{
			//	Debug.Log("30: " + SimulateTileCreation.NthFibonacciNumber(30));
			//	Debug.Log("35: " + SimulateTileCreation.NthFibonacciNumber(35));
			//	Debug.Log("40: " + SimulateTileCreation.NthFibonacciNumber(40));
			//});


		}
	}
}
