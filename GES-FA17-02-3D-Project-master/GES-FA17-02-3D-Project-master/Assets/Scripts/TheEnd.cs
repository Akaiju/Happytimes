using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{

    GameObject GameEnd;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }
}