using UnityEngine;

public class Delivery : MonoBehaviour
{
    private bool packagePickedUp = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && packagePickedUp == false)
        {
            GetComponent<SpriteRenderer>().color = collision.GetComponent<SpriteRenderer>().color;
            Debug.Log("Package picked up");
            packagePickedUp = true;
            Destroy(collision.gameObject);
        }

        if(collision.tag == "Customer" && packagePickedUp == true)
        {
            GetComponent<SpriteRenderer>().color = collision.GetComponent<SpriteRenderer>().color;
            Debug.Log("Package is delivered to the customer");
            packagePickedUp = false;
        }
    }
}
