using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float minBlow = 0;
    public float maxBlow;
    public float maxHeight;
    public MichrophoneInputLoudness michrophone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Blow(Mathf.Clamp(michrophone.loudness, minBlow, maxBlow));
    }

    public void Blow(float y)
    {
        if (transform.position.y < maxHeight)
        {
            transform.Translate(new Vector3(0, y, 0) * Time.deltaTime);
            //transform.localScale = new Vector3(y, y ,y);
        }
    }

}
