using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    float timeRemaining = 1;
    

    public PlayerScript2 playerScript;

    [SerializeField] private int health = 100;
    private Rigidbody m_Rigibody;
    private CapsuleCollider m_collider;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigibody = GetComponent<Rigidbody>();
        m_collider = GetComponent<CapsuleCollider>();
      
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
          
            m_Rigibody.constraints = RigidbodyConstraints.None;
            m_collider.isTrigger = true;
            Vector3 newrotation = new Vector3(90, 0, 0);
            transform.eulerAngles = newrotation;
            PlayerScript2.GhastlyEnergy += 25;
            gameObject.SetActive(false);
            
           







        }
    }
    private void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            health = health - 1;
            

        }
        if (collision.gameObject.tag == "Sword")
        {
            health = health - 5;


        }


    }
}
