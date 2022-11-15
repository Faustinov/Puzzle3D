using UnityEngine;

public class Activator : MonoBehaviour
{
    [SerializeField] private GameObject[] _firstGroup;
    [SerializeField] private GameObject[] _secondGroup;
    [SerializeField] private Activator _button;
    [SerializeField] private Material _normal;
    [SerializeField] private Material _transparent;

    public bool CanPush;

    private void OnTriggerEnter(Collider other)
    {
        if (CanPush)
        {
            if (other.CompareTag("Cube") || other.CompareTag("Player"))
            {
                foreach (GameObject first in _firstGroup)
                {
                    first.GetComponent<Renderer>().material = _normal;
                    first.GetComponent<Collider>().isTrigger = false;
                }
                foreach (GameObject second in _secondGroup)
                {
                    second.GetComponent<Renderer>().material = _transparent;
                    second.GetComponent<Collider>().isTrigger = true;
                }
                GetComponent<Renderer>().material = _transparent;
                _button.GetComponent<Renderer>().material = _normal;
                _button.CanPush = true;
            }
        }
    }
}
