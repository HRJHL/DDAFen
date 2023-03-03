using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController : MonoBehaviour
{
    [SerializeField]
    GameObject HomePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayScene() {
        SceneManager.LoadScene("GamePlay");
    }
    public void HeroScene() {
        SceneManager.LoadScene("Hero");
    }
    public void ShopScene() {
        SceneManager.LoadScene("Shop");
    }   
    public void SkillScene() {
        SceneManager.LoadScene("Skill");
    }
    public void HomeScene() {
        SceneManager.LoadScene("Home");
    }
}
