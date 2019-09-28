using UnityEngine;
using UnityEngine.SceneManagement;
public class level_complete : MonoBehaviour
{
   

   public void LoadnextLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
   }
}
