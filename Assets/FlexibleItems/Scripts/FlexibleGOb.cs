using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode()]
public class FlexibleGOb : MonoBehaviour
{
    public FlexibleObjData skinDataObj;

    protected virtual void OnskinOBJ()
    {
        //OnSkinOBJ()
    }

    public virtual void Awake()
    {
        OnskinOBJ();
    }

    public virtual void Update()
    {
        if (Application.isEditor)
        {
            OnskinOBJ();
        }
    }
}
