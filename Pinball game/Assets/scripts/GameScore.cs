using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScore : MonoBehaviour
{
    public static int score = 0;
    void OnGUI()
    {
        GUILayout.Label("Score:  " + score.ToString());
    }

}
