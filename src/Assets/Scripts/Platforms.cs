using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Platforms : MonoBehaviour

{
    public Vector3[] Target;
    private int _pointer;

    private GameObject _pasage;

    [SerializeField]
    private Vector3 _oldCoords;

    public float _spped;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var targetPosition = Target[_pointer];
        var distance = Vector2.Distance(transform.position, targetPosition);

        _oldCoords = transform.position;
        transform.position = Vector3.Lerp(transform.position, targetPosition, 1 / distance * _spped * Time.fixedDeltaTime);
        
        if (_pasage != null)
        {
            var dir = transform.position - _oldCoords;
            _pasage.transform.position += dir;
        }

        if (distance <= 0.1f)
        {
            _pointer++;
            if (_pointer >= Target.Length)
            {
                _pointer = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _pasage = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _pasage = null;
    }

    private void OnDrawGizmosSelected()
    {
        var oldPositin = transform.position;
        foreach (var item in Target)
        {
            Gizmos.DrawLine(oldPositin, item);
            var pos = Vector2.Lerp(oldPositin, item, 0.5f);
            var dist = Vector2.Distance(oldPositin, item);
            oldPositin = item;
            Gizmos.DrawCube(item, Vector2.one / 5);
            Handles.Label(pos, dist.ToString());
        }
    }

}
