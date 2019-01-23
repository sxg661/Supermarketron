﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : CustomerBehaviour {

    SpriteRenderer spriteRenderer;
    int y;

    public override string myType()
    {
        return "idle";
    }

    public Idle(int y)
    {
        this.y = y;
    }



    // Use this for initialization
    public override void Init(SpriteRenderer renderer, Transform transform, DoneDel doneMethod) {
        spriteRenderer = renderer;
        done = doneMethod;


    }


    private void setSortingLayer()
    {
        spriteRenderer.sortingOrder = TileGrid.getSortingNum(Tile.getTile(y));

    }






     // Move the AI
    public override void Update()
    {
        setSortingLayer();

        done();
    }

    
}

