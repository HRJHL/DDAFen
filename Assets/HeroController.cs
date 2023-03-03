using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
    [SerializeField]
    GameObject HeroPanel;

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
