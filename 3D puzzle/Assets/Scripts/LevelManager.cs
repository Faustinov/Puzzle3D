using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _levelText;

    private void Start()
    {
        _levelText.text = SceneManager.GetActiveScene().name;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PrevioussLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
