using UnityEngine;
using UnityEngine.SceneManagement;

namespace Snog.DialogueSystem.Demo
{
    [RequireComponent(typeof(Renderer))]
    public class NextChapterOne : MonoBehaviour
    {
        public void ChangeColor(string key)
        {
            if (key != "next_Chapter1")  return;

            Debug.Log("hey guys");
            SceneManager.LoadSceneAsync("Chapter1");
        }
    }
}