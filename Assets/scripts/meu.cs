using UnityEngine;
using UnityEngine.SceneManagement;

public class meu : MonoBehaviour
{
   public void start_game()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
