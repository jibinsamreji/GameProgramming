﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHandlerG : MonoBehaviour {
    public GameObject human;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
   


    private SpriteRenderer spriteRend;

    void Start()
    {
        // Initialization of component references

        spriteRend = human.GetComponent<SpriteRenderer>();

    }
    // Executes when a mouse down event occurs on an object with this script.
    void OnMouseDown()
    {
        if (spriteRend.sprite != secondImage)
        {
            spriteRend.sprite = secondImage;
        }
        else
        {
            spriteRend.sprite = secondImage;
        }


    }
}
