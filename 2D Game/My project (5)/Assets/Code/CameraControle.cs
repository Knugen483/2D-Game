using UnityEngine;

public class CameraControle : MonoBehaviour
{
    [SerializeField] Transform playerTransform;

    [SerializeField] Vector3 offset;

    [SerializeField] float cameraMoveSpeed;
    [SerializeField] PlayerControler player;

    private void Start()
    {
        playerTransform = FindAnyObjectByType<PlayerControler>().transform;
        offset = transform.position - playerTransform.position;
    }




    private void FixedUpdate()
    {
       if (player.isGrounded)
       {
            transform.position = playerTransform.position + offset;
       }
       else
       {
            transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
       }
    }





}
