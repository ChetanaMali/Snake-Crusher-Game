using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField] float snakeSpeed;
    [SerializeField] float rotatespeed;
    [SerializeField] GameObject snakeBodyPref;
    [SerializeField] int gap;
    [SerializeField] float bodySpeed;

    List<GameObject> bodyPart = new List<GameObject>();
    List<Vector3> StorePosition = new List<Vector3>();

    

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            SneckBody();
        }
       
       
    }
    void Update()
    {
        //Move sneck Forward
        
        transform.position += transform.forward * snakeSpeed * Time.deltaTime;

        // Move Sneck Right And left
        float rotation = Input.GetAxisRaw("Horizontal");
        transform.Rotate(Vector3.up * rotation  * rotatespeed * Time.deltaTime);

        // store Transform of bodypart
        StorePosition.Insert(0, new Vector3(transform.position.x, transform.position.y, transform.position.z));

        // Move Body part
        int index = 0;
        foreach (var body in bodyPart)
        {
            Vector3 point = StorePosition[Mathf.Min(index * gap, StorePosition.Count - 1)];
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * bodySpeed * Time.deltaTime;
            body.transform.LookAt(point);

            index++;
        }
    }
    void SneckBody()
    {
        GameObject body = Instantiate(snakeBodyPref);
        bodyPart.Add(body);
    }
   
}
