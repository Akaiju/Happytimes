using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeObject : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(1);
    }
}