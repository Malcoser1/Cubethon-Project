using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level01");
    }
   
}