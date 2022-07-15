using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject car;

    private void LateUpdate()
    {
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, transform.position.z);
    }
}
