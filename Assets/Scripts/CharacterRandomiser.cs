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
            if (Random.Range(0, 2) == 0)
                isEnemy = true;
            else
                isEnemy = false;

            Debug.Log(isEnemy);
        }
        private void Update()
        {
            if (isEnemy)
                renderer.material.color = Color.red;
            else
                renderer.material.color = Color.gray;


            Debug.Log("Вызвали апдейт");

        }
    }
       
    
}
