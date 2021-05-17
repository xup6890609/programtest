using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        print("跑酷ing...");
        SceneManager.LoadScene("SampleScene");
    }

    public void ReStartGame()
    {
        print("重新啟程");
        SceneManager.LoadScene("menu");
}
public void QuitGame()
{
 print("放棄治療");
 Application.Quit();
}
}
