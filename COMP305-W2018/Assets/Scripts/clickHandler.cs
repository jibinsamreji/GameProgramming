using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickHandler : MonoBehaviour {

    //// Use this for initialization
    //void Start () {

    //}

    //// Update is called once per frame
    //void Update () {

    //}
    public GameObject humanoid;
    public Sprite firstImage;
    public Sprite secondImage;
    public Sprite thirdImage;
   



    private SpriteRenderer spriteRend;

    void Start()
    {
        // Initialization of component references
        
        spriteRend = humanoid.GetComponent<SpriteRenderer>();

    }
    // Executes when a mouse down event occurs on an object with this script.
    void OnMouseDown()
    {
        if (spriteRend.sprite != firstImage)
        {
            spriteRend.sprite =firstImage;
        }
        else
        {
            spriteRend.sprite = firstImage;
        }

      
    }
}
