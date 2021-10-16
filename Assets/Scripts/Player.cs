using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;
        transform.position += nextPos;
    }
}
