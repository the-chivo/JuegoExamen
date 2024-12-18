using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score1Script : MonoBehaviour
{
    // Start is called before the first frame update
    public bool p1Touching = false;
    [SerializeField] score2Script score2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, 0.3f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("P1"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            print("a");
            p1Touching = true;
            if (score2.p2Touching == true && p1Touching == true)
            {
                gameObject.transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-4, 4), 0);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        p1Touching = false;
    }
}
