using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEvents : MonoBehaviour
{
    public static LevelEvents lEvents;
    public int playerPillar=0;

    // Start is called before the first frame update
    void Start()
    {
        lEvents = this;
    }

    // this is called when the player lands on each pillar
    public void NextPillar()
    {
        playerPillar += 1;
    }

    // when the player looks down?
}
