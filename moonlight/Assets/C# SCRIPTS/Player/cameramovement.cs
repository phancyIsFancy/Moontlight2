using UnityEngine;

public class cameramovement : MonoBehaviour
{
    [SerializeField]
    float sensitivity;

    [SerializeField]
    Transform player;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        RotateCamera();
    }

    void RotateCamera() 
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * sensitivity;
        float rotAmountY = mouseY * sensitivity;

        Vector3 rotplayer = player.transform.rotation.eulerAngles;

        rotplayer.y += rotAmountX;
        rotplayer.y += rotAmountY;

        player.rotation = Quaternion.Euler(rotplayer);

    }

    
  


}
