using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Light2Change : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private int spriteState2;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteState2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
        }
    }


    void ChangeSprite() 
    {   
        spriteState2 = (spriteState2 + 1) % 2;
        spriteRenderer.sprite = spriteArray[spriteState2]; 
    }

}
