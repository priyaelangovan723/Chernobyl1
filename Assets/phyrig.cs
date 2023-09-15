using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phyrig : MonoBehaviour
{
    public Transform playerHead;
    public CapsuleCollider bodyCollider;

    public float bodyHeightMin = 4;
    public float bodyHeightMax = 6;

    // Start is called before the first frame update
     void FixedUpdate()
    {
        bodyCollider.height = Mathf.Clamp(playerHead.localPosition.y, bodyHeightMin, bodyHeightMax);
        bodyCollider.center = new Vector3(playerHead.localPosition.x, bodyCollider.height / 2,
            playerHead.localPosition.z);
        
    }
}
