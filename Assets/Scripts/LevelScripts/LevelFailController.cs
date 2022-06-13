
using UnityEngine;

public class LevelFailController : MonoBehaviour
{
    public Transform spawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {   
            Debug.Log("Level Failed!");

            collision.gameObject.GetComponent<PlayerController>().Respawn();
        }
    }    
    
}