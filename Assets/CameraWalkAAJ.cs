using UnityEngine;
using System.Collections;

public class CameraWalkAAJ : MonoBehaviour
{

    public CardboardHead head;


    void Start()
    {
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(head.transform.forward.x, 0, head.transform.forward.z).normalized * 0.01f;
        Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));

        Vector3 move = rotation * direction;
        transform.Translate(move);
    }
}
