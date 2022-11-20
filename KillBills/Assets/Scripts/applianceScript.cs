using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class applianceScript : MonoBehaviour
{

    public Sprite offImage;
    public Sprite onImage;
    public Image imageRender;
    public Button applianceButton;


    // Start is called before the first frame update
    void Start()
    {
        applianceButton.onClick.AddListener(TurnOff);
        StartCoroutine(Wait());
    }

    void TurnOff()
    {
        imageRender.sprite = offImage;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(10,20));
        imageRender.sprite = onImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
