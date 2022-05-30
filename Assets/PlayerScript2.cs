using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript2 : MonoBehaviour
{
    private Rigidbody m_Rigibody;

    private Vector3 m_Movement;
    [SerializeField] private float m_Speed;
    public static int health = 100;

    [SerializeField] private float fly = 10;

    public float SubtractEnergyPerSecond;

    [SerializeField] public static float GhastlyEnergy = 50;

    private CapsuleCollider m_collider;

    public static bool Alive;

    [Range(-1f, 1f)]

    public float horizontalSpeed;

    [Range(0, 5)]

    public float verticalSpeed;

    [Range(0, 2)]

    public float amplitude;



   

    // Start is called before the first frame update
    void Start()
    {
        Alive = true;
        m_Rigibody = GetComponent<Rigidbody>();

        m_collider = GetComponent<CapsuleCollider>();
    }

    void FixedUpdate()
    {
        Vector3 Direction = transform.TransformDirection(m_Movement);
        m_Rigibody.velocity = Direction * m_Speed * Time.fixedDeltaTime;
    }


    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");


        m_Movement = new Vector3(h, 0, v).normalized;

        if (health <= 0)
        {
            Alive = false;

            m_collider.isTrigger = true;

            if (Input.GetKey(KeyCode.Space))
            {
                m_Rigibody.AddForce(0, fly ,0);
            }
            if (Input.GetKey(KeyCode.F))
            {
                m_Rigibody.AddForce(0, -fly ,0);
            }

            health = 0;
            SubtractEnergyPerSecond = 3;
            GhastlyEnergy -= SubtractEnergyPerSecond * Time.deltaTime;
            //Debug.Log(GhastlyEnergy);






        }

        if (GhastlyEnergy <= 0)
        {
            SceneManager.LoadScene("Menu");
        }

        if (GhastlyEnergy >= 100)
        {
            GhastlyEnergy = 100;
        }

        if (health >= 1)
        {
            GhastlyEnergy = 50;
            SubtractEnergyPerSecond = 0;
            Alive = true;
        }
    }

   

}
