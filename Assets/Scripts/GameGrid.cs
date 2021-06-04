using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour 
{
    public float CellSize = 1f;
    [HideInInspector] public List<UnitControl> PlayerUnitList;
    [HideInInspector] public List<UnitControl> EnemyUnitList;
    public UnitControl[,] UnitTable;

    public void Awake() // PITÄISIKÖ olla Awake vai Start vai molemmat?
    {
        // TODO
    }

    public float ConvertGridPosToRealPos(int a)
    {
        return a * CellSize + 0.5f;
    }

    // DEBUGGING
    public void PrintPlayerUnitList()
    {
        string row = "";
        for (int i = 0; i < PlayerUnitList.Count; i++)
        {
            row = (row + PlayerUnitList[i] + ", ");
        }
        Debug.Log(row);
    }

    // DEBUGGING
    public void PrintenemyUnitList()
    {
        string row = "";
        for (int i = 0; i < EnemyUnitList.Count; i++)
        {
            row = (row + EnemyUnitList[i] + ", ");
        }
        Debug.Log(row);
    }

    // DEBUGGING
    public void PrintUnitTable()
    {
        for (int i = 0; i < UnitTable.GetLength(0); i++)
        {
            string row = "";
            for (int j = 0; j < UnitTable.GetLength(1); j++)
            {
                row = (row + UnitTable[i,j] + ", ");
            }
            Debug.Log(row);
        }
    }
}
