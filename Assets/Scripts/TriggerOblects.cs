using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOblects : MonoBehaviour
{
    [SerializeField] GameObject flowChart;




    private void Start()
    {
        flowChart.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("Нажмите E");
        flowChart.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {

        Debug.Log("Вы слишком далеко");
        flowChart.SetActive(false);
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Диалог начат");
            }
        }
    }
}
