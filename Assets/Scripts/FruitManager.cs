using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{

    [Header("Elements")]
    [SerializeField] GameObject fruitPrefabs;
    [Header("Settings")]
    [SerializeField] float fruitYPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ManagerPlayerInput();
        }
    }

    void ManagerPlayerInput()
    {
        // đổi vị trí click từ trên xuống
        Vector2 pos = GetClickedWorkPosition();
        pos.y = fruitYPosition;
        Instantiate(fruitPrefabs, pos, Quaternion.identity);

        // Spawn prefabs tại điểm click chuột9
        //Instantiate(fruitPrefabs, GetClickedWorkPosition(), Quaternion.identity);
    }

    // click chuột lấy toạ độ trên Screen
    public Vector2 GetClickedWorkPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
