using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            SceneManager.LoadScene(1);
        }
    }
}