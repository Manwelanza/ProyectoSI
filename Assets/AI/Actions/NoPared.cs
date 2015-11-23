using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;
using RAIN.Representation;
using RAIN.Entities;
using RAIN.Entities.Aspects;

[RAINAction]
public class NoPared : RAINAction
{

    public Expression Detectado = new Expression();


    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {

        RaycastHit hit;
        Ray ray = new Ray(GameObject.Find("Enemigo").transform.position, GameObject.Find("Enemigo").transform.forward);
        if (Physics.Raycast(ray, out hit, 5f))
        {
            if (hit.collider.gameObject == GameObject.Find("Player").gameObject)
            {
                
                Debug.Log("hey");
            }
            else
            {
                Detectado = null;
            }
            if (hit.collider.gameObject == GameObject.Find("Cobertura (1)").gameObject)
            {
                
            }
        }

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }

}