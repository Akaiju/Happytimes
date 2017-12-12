using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    void Start()
    {
        //Button btn = yourButton.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
    }

    public void Task(int index)
    {
        SceneManager.LoadScene(index);
        Debug.Log("Scene must be loaded.");
    }
}