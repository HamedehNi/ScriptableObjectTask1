using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()]
public class FlexibleUI : MonoBehaviour
{
    public FlexibleUIData skinData;

    protected virtual void OnskinUI()
    {
        //OnSkinUI()
    }

    public virtual void Awake()
    {
        OnskinUI();
    }

    public virtual void Update()
    {
        if(Application.isEditor)
        {
            OnskinUI();
        }
    }
}
