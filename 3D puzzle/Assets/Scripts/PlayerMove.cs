using System.Runtime.InteropServices;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();
    [SerializeField] private KeyCode _keyOne;
    [SerializeField] private KeyCode _keyTwo;
    [SerializeField] private Vector3 _moveDirection;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            FindObjectOfType<LevelManager>().Reset();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {       
            FindObjectOfType<LevelManager>().NextLevel();
            ShowAdv();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            FindObjectOfType<LevelManager>().PrevioussLevel();
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(_keyOne))
        {
            GetComponent<Rigidbody>().velocity += _moveDirection;
        }

        if (Input.GetKey(_keyTwo))
        {
            GetComponent<Rigidbody>().velocity -= _moveDirection;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.CompareTag("Player") && other.CompareTag("Finish"))
        {
            FindObjectOfType<LevelManager>().NextLevel();
        }

        if(this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach(Activator button in FindObjectsOfType<Activator>())
            {
                button.CanPush = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (this.CompareTag("Cube") && other.CompareTag("Cube"))
        {
            foreach (Activator button in FindObjectsOfType<Activator>())
            {
                button.CanPush = true;
            }
        }
    }
}
