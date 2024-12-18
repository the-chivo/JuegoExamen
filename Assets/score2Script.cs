using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score2Script : MonoBehaviour
{
    // Start is called before the first frame update
    public bool p2Touching = false;
    [SerializeField] score1Script score1;
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
        if (collision.gameObject.CompareTag("P2"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            print("si");
            p2Touching = true;
            if (score1.p1Touching == true && p2Touching == true)
            {
                gameObject.transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-4, 4), 0);
            }
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        p2Touching = false;
    }
}
