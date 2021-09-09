using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool movingRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        if (movingRight)
        {
            transform.Translate(new Vector2(speed * Time.deltaTime, 0), Space.World);
        }
        else
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0), Space.World);
    }
}
