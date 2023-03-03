using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkillController : MonoBehaviour
{
    [SerializeField]
    GameObject SkillPanel;

    public void ShopScene() {
        SceneManager.LoadScene("Shop");
    }
    public void HeroScene() {
        SceneManager.LoadScene("Hero");
    }
    public void HomeScene() {
        SceneManager.LoadScene("Home");
    }
}
