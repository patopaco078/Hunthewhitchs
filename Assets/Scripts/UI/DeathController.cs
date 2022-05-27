using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    [SerializeField] GameObject DeathScreen;

    private void Start()
    {
        DeathScreen.SetActive(false);
    }
    public void Kill()
    {
        DeathScreen.SetActive(true);
        StartCoroutine(ReloadScene());
    }

    IEnumerator ReloadScene()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Map");
    }

}
