using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC2Change : MonoBehaviour
{
    public SpriteRenderer pc2Sprite;
    public Sprite[] pcSpriteArray;
    private int pc2State;

    // Start is called before the first frame update
    void Start()
    {
        pc2Sprite = gameObject.GetComponent<SpriteRenderer>();
        pc2State = 0;
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
        pc2State = (pc2State + 1) % 2;
        pc2Sprite.sprite = pcSpriteArray[pc2State]; 
    }
}
