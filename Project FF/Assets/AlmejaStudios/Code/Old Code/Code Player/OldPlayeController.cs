using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OldPlayeController : MonoBehaviour
{
    public GameObject Cars, lose;
    public AudioSource loseSound, music, motorSound, trophySound;
    public TextMeshProUGUI POINTS;
    [SerializeField] IntVariable score;
    float time = 3f;
    float elapsedTime;
    [SerializeField] floatVariable speed;
    public string SceneToLoad;


    private void Start()
    {
        score.Value = 0;
        speed.Value = 10;
    }
    private void Update()
    {
        score.Value = Mathf.Clamp(score.Value, 00, 999999999999999);
        POINTS.text = score.Value.ToString();
        /*
        if (lose.GameObject.SetActive = true)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= time)
            {
                SceneManager.LoadSceneAsync(SceneToLoad);
            }
        }
        */
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("points"))
        {
            trophySound.GetComponent<AudioSource>().Play();
            score.Value ++;
            Destroy(other.gameObject, 0);
        }
        else 
        if (other.gameObject.CompareTag("enemyCar"))
        {
            
            music.GetComponent <AudioSource>().Stop();
            motorSound.GetComponent<AudioSource>().Stop();
            lose.SetActive(true);
            loseSound.GetComponent < AudioSource>().Play();
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
