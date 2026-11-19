using UnityEngine;
using UnityEngine.InputSystem;
public class Mouse_Click : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            mousePos.z = 0;

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit)
            {
                print("hit!! " + hit.collider.gameObject.name);
                if (hit.collider.gameObject == gameObject)
                {
                    gameObject.SetActive(false);
                }
            }

        }
    }
}
