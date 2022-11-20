using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PC1Change : MonoBehaviour
{
    public SpriteRenderer pc1Sprite;
    public Sprite[] pcSpriteArray;
    private int pc1State;

    // Start is called before the first frame update
    void Start()
    {
        pc1Sprite = this.gameObject.GetComponent<SpriteRenderer>();
        pc1State = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {   
            Vector3 mousePos = Input.mousePosition;
            
            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);
            
            
        }
    }

    void ChangeSprite() 
    {   
        pc1State = (pc1State + 1) % 2;
        pc1Sprite.sprite = pcSpriteArray[pc1State]; 
    }
}
