using UnityEngine;

public class Ship_Motion : MonoBehaviour
{
    public Rigidbody rb;
    public int force_magnitude = 30;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 ship_position = transform.position;
            Vector3 mouse_position = Input.mousePosition;
            Vector3 motion_vector_norm = (mouse_position-ship_position).normalized;
            Vector3 motion_vector = force_magnitude * motion_vector_norm;
            rb.AddForce(motion_vector);
            Debug.Log("Pressed Space");
        }
    }
}
