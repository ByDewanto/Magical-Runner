using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buildingmov : MonoBehaviour
{
    private Rigidbody2D building;
    private float speed = 4f;
    // Start is called before the first frame update
    private void Awake() {
        building = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        building.velocity = new Vector2(-speed, building.velocity.y);
    }
}
