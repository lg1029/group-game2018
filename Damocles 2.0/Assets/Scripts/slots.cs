﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour 
{
    public void DropItem()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
}
	