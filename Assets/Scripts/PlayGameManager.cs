using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainmenuPanel;
    [SerializeField] private GameObject _rankPanel;
    public void RankButton()
    {
        _rankPanel.SetActive(true);
        _mainmenuPanel.SetActive(false);

    }
    public void MainMenuBtn()
    {
        _rankPanel.SetActive(false);
        _mainmenuPanel.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("PlayGame");
    }
}
