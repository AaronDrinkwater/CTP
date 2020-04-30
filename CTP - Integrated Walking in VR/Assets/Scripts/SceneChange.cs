using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject portal_1;
    public GameObject portal_2;
    public GameObject portal_3;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider ChangeScene) // can be Collider HardDick if you want.. I'm not judging you
    {
        if (this.gameObject == portal_1)
        {
            if (ChangeScene.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene("TestScene"); //1 is the build order it could be 1065 for you if you have that many scenes
            }

        }

        if (this.gameObject == portal_2)
        {
            if (ChangeScene.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene("TestScene2"); //1 is the build order it could be 1065 for you if you have that many scenes
            }
        }

        if (this.gameObject == portal_3)
        {
            if (ChangeScene.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene("TestScene3"); //1 is the build order it could be 1065 for you if you have that many scenes
            }
        }
    }
}
