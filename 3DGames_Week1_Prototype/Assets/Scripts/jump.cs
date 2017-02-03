using UnityEngine;

public class jump : MonoBehaviour
{
    public float thrust;

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collision!");
            col.gameObject.GetComponent<Rigidbody>().AddForce(0, thrust, 0);
        }
            }
}
