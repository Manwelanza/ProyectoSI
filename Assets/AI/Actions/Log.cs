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
public class Log : RAINAction
{

    public Expression Detectado = new Expression();


    public override ActionResult Execute(RAIN.Core.AI ai)
    {

        Debug.Log(Detectado.ToString());
        return ActionResult.SUCCESS;
    }


}