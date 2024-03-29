using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{
    private Vector2 initialPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) initialPos = Input.mousePosition;
        if (Input.GetMouseButtonUp(0)) Calulate(Input.mousePosition);
        
    }

    void Calulate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(initialPos.x - finalPos.x);
        float disY = Mathf.Abs(initialPos.y - finalPos.y);

        if (disX > 0 || disY > 0)
        {
            if (disX > disY)
            {
                if (initialPos.x > finalPos.x) Debug.Log("left");
                else Debug.Log("right");
            }
            else {
                if (initialPos.y > finalPos.y) Debug.Log("Down");
                else Debug.Log("Up");
            }
        }
    }
}
