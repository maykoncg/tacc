using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayScene()
    {
        SceneManager.LoadScene("Aviao");
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void CreditosScene()
    {
        SceneManager.LoadScene("creditos");
    }
}
