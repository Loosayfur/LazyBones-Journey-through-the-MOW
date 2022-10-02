using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Customizable : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Customization> customizations;
    public Customization currentCustomization { get;private set; }
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

}

[Serializable]
public class Customization 
{
    public List<Renderer>[] Renderers;
    public List<SpriteRenderer> spritesHead;
    public List<SpriteRenderer> spritesBody;
    public List<SpriteRenderer> spritesSkin;
    public List<SpriteRenderer> spritesSleeves;
    public List<SpriteRenderer> spritesShoes;
    public List<SpriteRenderer> spritesBelt;
    public Color colour;

    

    
}
