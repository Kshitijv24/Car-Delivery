using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("i got hit by: " + collision.name);
    }
}
