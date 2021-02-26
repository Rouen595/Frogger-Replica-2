using UnityEngine;
using UnityEngine.SceneManagement;

public class Border : MonoBehaviour
{
    public Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Frog") { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
