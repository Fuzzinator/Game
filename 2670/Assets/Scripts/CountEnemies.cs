using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CountEnemies : MonoBehaviour {

    public static List<GameObject> enemies;
    public static List<GameObject> friends;

    // Use this for initialization
    void Start()
    {
        enemies = new List<GameObject>();
        friends = new List<GameObject>();
    }

    public void enemiesSize()
    {
        print("There are " + enemies.Count + " foes.");
        friendsSize();
    }

    public static void friendsSize()
    {
        print("There are " + friends.Count + " friends.");
    }
}
