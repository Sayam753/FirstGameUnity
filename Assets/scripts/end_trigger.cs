using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_trigger : MonoBehaviour
{
    public manager game_manager;
    void OnTriggerEnter()
    {
        game_manager.complete_level();
    }
}
