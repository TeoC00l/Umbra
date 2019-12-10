using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour
{

    private bool play = false;
    [SerializeField] private GameObject credits;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayCredits());
    }

    private IEnumerator PlayCredits()
    {
        yield return new WaitForSeconds(5);
        play = true;
    }

    private void Update()
    {
        if (play)
        {
            credits.transform.position += Vector3.up * 50 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if(credits.transform.position.y > 1800)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
