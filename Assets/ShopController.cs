using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    [SerializeField]
    GameObject ShopPanel;

    public void HeroScene() {
        SceneManager.LoadScene("Hero");
    }
    public void SkillScene() {
        SceneManager.LoadScene("Skill");
    }
    public void HomeScene() {
        SceneManager.LoadScene("Home");
    }
}
