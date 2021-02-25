using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSet : MonoBehaviour
{
    public AnimatedElementEx ae;

    public void SetTarget(AnimatedBehaviour aeb, float time)
    {
        if (aeb.mainTransform.localScale != Vector3.zero)
        {
            ae.transformation.to_transformPos = aeb.rtr.anchoredPosition;
            ae.transformation.Restart();
        }
    }
}