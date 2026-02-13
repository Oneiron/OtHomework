using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.TextCore.Text;
namespace Project
{

    public class CharacterRandomiser : MonoBehaviour
    {
       [SerializeField] public MeshRenderer _renderer;
        
        public bool isEnemy;

        private void Start()
        {
            isEnemy = Random.Range(0, 2) == 0;
           
            Debug.Log(isEnemy);
        }
        private void Update()
        {
            Render();


            Debug.Log("������� ������");

        }

        private void Render()
        {
            if (isEnemy)
                GetComponent<Renderer>().material.color = Color.red;
            else
                GetComponent<Renderer>().material.color = Color.blue;
        }
    }
       
    
}
