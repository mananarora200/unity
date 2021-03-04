using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveleft : MonoBehaviour
{
    public float speed;
    private PlayerController script;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.isGameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < -20 && gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
