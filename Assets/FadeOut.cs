using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    protected Image sprite;
    [Tooltip("Higher values = faster Fade Out")]
    public float fadeSpeed = 1f;

    private bool Work = false;

    public void Start()
    {
        //If you didn't drag the component
        if (sprite == null)
            sprite = GetComponent<Image>();
    }

    public void Update()
    {
        //Modify the color by changing alpha value
      
        if (Work)
        {
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a + (fadeSpeed * Time.deltaTime));
            if(sprite.color.a >= 1)
            {
                Work = false;
            }
        }
        else if(sprite.color.a > 0)
        {
            sprite.color = sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, sprite.color.a - (fadeSpeed * Time.deltaTime));
        }
    }

    public void ShowCloud()
    {
        this.Work = true;
    }
}