using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class Disparar : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
		Enemigo enemigo;
		for(int j = 0; j < GameObject.Find("Enemigos").GetComponentsInChildren<Enemigo>().Length; j++) {

			if(j == 0)
				enemigo = GameObject.Find("Enemigo").GetComponentInChildren<Enemigo>();
			else
				enemigo = GameObject.Find("Enemigo (" + j + ")").GetComponentInChildren<Enemigo>();

			enemigo.dispara();
		}

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}