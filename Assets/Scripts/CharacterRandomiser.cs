using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;
namespace Project
{

    public class CharacterRandomiser : MonoBehaviour
    {
        public Renderer renderer;
        
        public bool isEnemy;

        private void Start()
        {
            isEnemy = Random.Range(0, 2) == 0;
           
            Debug.Log(isEnemy);
        }
        private void Update()
        {
            Render();


            Debug.Log("Вызвали апдейт");

        }

        private void Render()
        {
            if (isEnemy)
                renderer.material.color = Color.red;
            else
                renderer.material.color = Color.gray;
        }
    }
       
    
}
