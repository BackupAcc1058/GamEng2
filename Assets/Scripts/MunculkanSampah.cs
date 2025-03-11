using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class MunculSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda) {
            int random = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
