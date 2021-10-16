using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float collideHorizontal = 1;
    private float collideVertical = 1;

    private void Update()
    {

        float h = Input.GetAxisRaw("Horizontal") * collideHorizontal;
        float v = Input.GetAxisRaw("Vertical") * collideVertical;

        Vector3 nextPos = new Vector3(h, v, 0) * speed * Time.deltaTime;
        transform.position += nextPos;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Border")
        {
            if (other.gameObject.name == "Vertical")
            {
                collideVertical = 0;
            }
            else if (other.gameObject.name == "Horizontal")
            {
                collideHorizontal = 0;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Border")
        {
            if (other.gameObject.name == "Vertical")
            {
                collideVertical = 1;
            }
            else if (other.gameObject.name == "Horizontal")
            {
                collideHorizontal = 1;
            }
        }
    }


}
