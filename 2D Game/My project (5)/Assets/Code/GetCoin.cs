using UnityEngine;

public class GetCoin : MonoBehaviour
{
    [SerializeField] GameObject Gold_coinPreFab;
    [SerializeField] bool moneyrighttax = true;
    [SerializeField] Sprite Coin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && moneyrighttax)
        {
            if (collision.GetComponent<Rigidbody2D>().linearVelocityY > -0.1f)
            {

                Instantiate(Gold_coinPreFab, transform.position + new Vector3(0, 2.5f, 0), Quaternion.identity);
                collision.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = 0;
                moneyrighttax = false;
                GetComponent<SpriteRenderer>().sprite = Coin;
                

            }


        }













    }
}