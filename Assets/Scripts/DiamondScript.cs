using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    public float rotationSpeed = 200;
    public SpriteRenderer rend;
    public Color newColor;
    public Transform other;



    void Start()
    {
        rend.color = newColor;
        rend.color = new Color(1f, 0.5f, 0.3f);
        //other.position = new Vector3(3, 2, other.position.z);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
        }

        transform.Translate(5 * Time.deltaTime, 0, 0);
    }
}
