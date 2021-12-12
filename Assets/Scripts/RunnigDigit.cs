using UnityEngine;
using UnityEngine.UI;

public class RunnigDigit : MonoBehaviour
{
    [SerializeField]
    private float Speed;
    [SerializeField]
    private Sprite[] Numbers;
    private Transform _transform;
    private Image _image;
    private int count = 0;
    void Start()
    {
        _transform = GetComponent<Transform>();
        _image = GetComponent<Image>();
    }
    void FixedUpdate()
    {
        if(_transform.position.y > -1100f)
        {
            System.Random r = new System.Random();
            if(count++ % 3 == 0 || count == 0)
            {
                _image.sprite = Numbers[r.Next(0, Numbers.Length)];
            }
            _transform.Translate(new Vector3(0, -Speed, 0));
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
