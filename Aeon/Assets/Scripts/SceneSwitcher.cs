using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneSwitcher : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Forest Biome");
    }
}