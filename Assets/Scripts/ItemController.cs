using UnityEngine;

public class ItemController : MonoBehaviour
{

    [SerializeField]
    private LayerMask groundLayerMask;

    [SerializeField]
    private GroundController groundController;

    private new Rigidbody rigidbody;

    private bool isGrounded;

    private void Awake()
    {

        rigidbody = gameObject.GetComponent<Rigidbody>();

    }

    private void Update()
    {

        isGrounded = Physics.CheckSphere(gameObject.transform.position, 0.75f, groundLayerMask);

    }

    private void Bounce()
    {

        if (isGrounded)
        {

            rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);

        }

    }

    private void OnEnable()
    {

        groundController.GroundPound += Bounce;

    }

    private void OnDisable()
    {

        groundController.GroundPound -= Bounce;

    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(gameObject.transform.position, 0.75f);

    }

}
