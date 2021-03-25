
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class CameraMovement : MonoBehaviour {
    // Update is called once per frame
    private float zoomSpeed = 5;
    private float targetOrtho;
    private float smoothSpeed = 5.0f;
    private float minOrtho = 2.0f;
    private float maxOrtho = 80.0f;
    void Start(){
        targetOrtho = Camera.main.orthographicSize;
    }

    private void Update() {
        Vector3 moveDir = new Vector3(0, 0);
        if (Input.GetKey(KeyCode.W)) {
            moveDir.y = +1;
        }
        if (Input.GetKey(KeyCode.S)) {
            moveDir.y = -1;
        }
        if (Input.GetKey(KeyCode.A)) {
            moveDir.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) {
            moveDir.x = +1;
        }
        float manualCameraSpeed = 80f;
        transform.position += moveDir * manualCameraSpeed * Time.deltaTime;


        float scroll = Input.GetAxis ("Mouse ScrollWheel");
        if (scroll != 0.0f) {
             targetOrtho -= scroll * zoomSpeed;
            targetOrtho = Mathf.Clamp (targetOrtho, minOrtho, maxOrtho);
        }
        
         Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
    }
}