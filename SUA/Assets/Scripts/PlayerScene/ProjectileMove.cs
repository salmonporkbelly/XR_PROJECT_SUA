using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection; // 발사방향

    private void FixedUpdate() {
        float moveAmount = 3 * Time.fixedDeltaTime; // 이동 속도 설정
        transform.Translate(launchDirection * moveAmount); // translate로 이동
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Object") // Tag 값이 오브젝트인 경우
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Monster") // Tag 값이 Monster인 경우
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Monster>().Damaged(1);
        }

    }
}