using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitControl : MonoBehaviour
{
    public float MoveSpeed;
    public GameGrid GameGrid;

    private float TargetPosX;
    private float TargetPosY;

    public void Awake()
    {
        TargetPosX = transform.position.x;
        TargetPosY = transform.position.y;
    }

    /*public void Start()
    {
        MoveToGridPos(0, 0);
    }*/

    public void MoveToGridPos(int x, int y)
    {
        TargetPosX = GameGrid.ConvertGridPosToRealPos(x);
        TargetPosY = GameGrid.ConvertGridPosToRealPos(y);

        // TODO: Läheteä tieto Gridille
    }

    private bool IsInTargetPos()
    {
        return transform.position.x == TargetPosX && transform.position.y == TargetPosY;
    }

    public void Update()
    {
        if (!IsInTargetPos())
        {
            MoveTowardsTargetPos();
        }
    }

    private void MoveTowardsTargetPos()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(TargetPosX, TargetPosY), Time.deltaTime * MoveSpeed);
    }
}
