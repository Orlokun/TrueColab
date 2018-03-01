﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : AttackController
{

    protected override void Start()
    {
        base.Start();
        maxDistance = GetDistance();
    }

    protected override int GetDamage()
    {
        if (enhanced)
        {
            return damage + 2;
        }
        else
        {
            return damage;
        }
    }

    protected override float GetSpeed()
    {
        if (enhanced)
        {
            return speed * 1.5f;
        }
        else
        {
            return speed;
        }
    }

    protected override float GetDistance()
    {
        if (enhanced)
        {
            return maxDistance * 1.5f;
        }
        else
        {
            return maxDistance;
        }
    }
}
