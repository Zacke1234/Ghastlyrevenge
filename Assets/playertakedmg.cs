using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playertakedmg : MonoBehaviour
{
    public PlayerScript2 player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "HumanEnemy")
        {
            PlayerScript2.health -= 2;


        }
    }
}
