using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public string levelToLoad;

    private bool isDead;

    public bool canDeath = true;

    private void OnTriggerEnter(Collider player)
    {
        isDead = FindObjectOfType<GameManager>().gameHasEnded;
        FindObjectOfType<GameManager>().CompleteLevel();
        Invoke(nameof(SceneSelect), .5f);
    }

    private void SceneSelect()
    {
        if (isDead == false)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
