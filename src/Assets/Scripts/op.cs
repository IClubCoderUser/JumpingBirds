using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class op : MonoBehaviour
    {
        public Player2D player;

        public void Start ()
        {
            // player._health = 0;

            player.Health--;
            player.Health-=10;
        }
    }
}