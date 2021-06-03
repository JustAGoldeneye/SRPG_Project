using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour // POISTA MonoBehavior, kun/jos saat tämän luokan Battle alaiseksi 
{
    public Unit[] UnitList;
    public Unit[,] UnitTable;

    public void Awake() // MUUTA ehkä manuaalisesti ajattevaksi setupiksi, kun/jos saat tämän luokan Battle alaiseksi; PITÄISIKÖ olla Awake vai Start vai molemmat?
    {
        UnitTable = new Unit[2,5];
        PrintUnitTable();
    }

    // DEBUGGING
    public void PrintUnitList()
    {
        string row = "";
        for (int i = 0; i < UnitList.Length; i++)
        {
            row = (row + UnitList[i] + ", ");
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
