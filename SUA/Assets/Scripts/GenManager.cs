using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenManager : MonoBehaviour
{

    public GameObject Monster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit)) // Ray를 쐈을 때 물리 결과가 일어나면
            {
                if(hit.collider.tag == "Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monster);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.1f, 0.0f);
                    //cast.origin => ray를 쏜  시작점, hit.point는 Ray가 맞은 좌표
                    Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);
                }
            }
        }
    }
}
