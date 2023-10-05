using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Characters;
using UnityEngine.UI;

namespace Managers
{
    public class ManagerScript : MonoBehaviour
    {
        public PlayerScript player;
        public int startingHealth = 100;
        public Text playerUIText;

        // Start is called before the first frame update
        void Start()
        {
            player.SetHealth(startingHealth);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
