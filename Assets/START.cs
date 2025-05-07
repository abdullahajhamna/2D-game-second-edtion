using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class START : MonoBehaviour
{
   public void OnStartCilck()
   {
    SceneManager.LoadScene("the first level");

   } 
 

   public void OnExitClick()
   {
    UnityEditor.EditorApplication.isPlaying = false;

    Application.Quit();
   }
   
}
