
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentScript : MonoBehaviour
{
    [SerializeField] public Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        navMeshAgent.destination = movePositionTransform.position;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
}
