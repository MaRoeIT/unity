using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemy_controller : MonoBehaviour
{
    public float speed = 5f;
    public float minTime = 1f;
    public float maxTime = 5f;
    private Vector2 direction;
    private float Tm;
    // Start is called before the first frame update
    void Start()
    {
        direction = Random.insideUnitSphere;
        Tm = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        Tm -= Time.deltaTime;
        if (Tm <= 0f)
        {
            direction = Random.insideUnitCircle;
            Tm = Random.Range(minTime, maxTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
