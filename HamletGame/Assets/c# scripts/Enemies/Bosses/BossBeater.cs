using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class BossBeater : MonoBehaviour
{
    public static TextWriter w;
    public TextWriter globalWriter;
    private static bool waiting;
    public UnityEvent quit;
    void Start()
    {
        w = globalWriter;
        waiting = false;
    }
    public static void BeatBoss(int num)
    {
        switch (num)
        {
            case 1:
                PersistentData.SceneToPlay = 5;
                break;
            case 2:
                PersistentData.SceneToPlay = 6;
                break;
        }
        waiting = true;
    }
    void Update()
    {
        if (waiting)
        {
            if (w.TimeSinceFinished() > 3)
            {
                quit.Invoke();
            }
        }
    }
}
