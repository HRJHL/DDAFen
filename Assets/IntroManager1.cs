using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroManager1 : MonoBehaviour
{
    [SerializeField]
    GameObject StartPanel;
    [SerializeField]
    GameObject IntroPanel;
    [SerializeField]
    int time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayTime(time));
    }

    IEnumerator DelayTime(float time) {
        yield return new WaitForSeconds(time);

        IntroPanel.SetActive(false);
        StartPanel.SetActive(true);
    }
    
    public void ChangeScene() {
        SceneManager.LoadScene(1);
    }

}
