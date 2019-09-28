using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    bool game_has_ended = false;
    public GameObject  complete_level_ui;
    public void complete_level()
    {
        complete_level_ui.SetActive(true);
    }
    public void end_game()
    {
        if (game_has_ended == false)
        {
            game_has_ended=true;
            Debug.Log("Game Over!");
            Invoke("restart",2f);
        }
       
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
