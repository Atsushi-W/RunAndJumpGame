using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadingController : MonoBehaviour
{
    [SceneName]
    public string nextLevel;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene(nextLevel);
    }
}
