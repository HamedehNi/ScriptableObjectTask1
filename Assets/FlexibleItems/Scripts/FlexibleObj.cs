using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class FlexibleObj : FlexibleGOb
{
    Image image;

    protected override void OnskinOBJ()
    {
        base.OnskinOBJ();

        image = GetComponent<Image>();
    
        image.sprite = skinDataObj.GObjSprite;
    }
    
}
