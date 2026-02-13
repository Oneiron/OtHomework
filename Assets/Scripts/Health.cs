using UnityEngine;

namespace MyGame
{
    public class Health : MonoBehaviour
    {
        public int health = 100;
        public bool isDeath = false;

        public void setDamage(int damage)
        {
            if (isDeath == true)
                return;

            health -= damage;
            if(health<0)
                health = 0;
            if(health==0)
                isDeath = true;
            else isDeath = false;
        
        }

    }
}