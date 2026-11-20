using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] PlayerControler Player;


    Rigidbody2D Gold_coin;





    private void Start()
    {
        Gold_coin = GetComponent<Rigidbody2D>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

        Debug.Log("Coin");
    }





}
