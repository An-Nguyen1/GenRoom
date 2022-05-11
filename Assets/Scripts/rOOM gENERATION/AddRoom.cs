using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRoom : MonoBehaviour
{
    private RoomTemplates templates;

    public RoomTemplates Templates { get => templates; set => templates = value; }

    void Start()
    {

        Templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
        Templates.rooms.Add(this.gameObject);
    }
}
