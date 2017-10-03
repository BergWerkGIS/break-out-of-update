using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using System;

public class HeavyDutyWorker
{


	//TODO: implement pool, or Queue or whatever
	//private BackgroundWorker[] _workerPool;
	private BackgroundWorker _worker;

	public HeavyDutyWorker()
	{
		//_workerPool = new BackgroundWorker[System.Environment.ProcessorCount];

		_worker = new BackgroundWorker();
		_worker.WorkerSupportsCancellation = true;
		_worker.WorkerReportsProgress = true;
		_worker.DoWork += worker_DoWork;
	}


	public void StartWorking(Action stuffToDo)
	{
		_worker.RunWorkerAsync(stuffToDo);
	}

	private void worker_DoWork(object sender, DoWorkEventArgs e)
	{

		Action stuff2do = e.Argument as Action;
		stuff2do();
	}

}
