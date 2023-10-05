using UnityEngine;

namespace Characters
{
    public class PlayerScript : MonoBehaviour
    {
        public int health;

        public void SetHealth(int amount)
        {
            health = amount;
        }
    }
}