
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Grid
{
    //https://youtu.be/waEsGu--9P8?list=PLzDRvYVwl53uhO8yhqxcyjDImRjO9W722
    
    private int width;
    private int height;
    private int[,] gridArray;
    private float cellSize;

    private TextMesh[,] debugTextArray;
    public Grid(int width,int height, float cellSize){
        this.height = height;
        this.width = width;
        this.cellSize = cellSize;

        gridArray = new int[width,height];
        debugTextArray = new TextMesh[width,height];
        //Debug.Log(width+ "  " + height); // Debug Line

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                //Debug.Log(x + " " + y); // Debug Line
                debugTextArray[x,y] =  UtilsClass.CreateWorldText(gridArray[x,y].ToString(),null,GetWorldPosition(x,y)+new Vector3(cellSize,cellSize)*0.5f,20,Color.white,TextAnchor.MiddleCenter);
                Debug.DrawLine(GetWorldPosition(x,y),GetWorldPosition(x,y+1),Color.white,100f);
                Debug.DrawLine(GetWorldPosition(x,y),GetWorldPosition(x+1,y),Color.white,100f);
            }
            
        }
        Debug.DrawLine(GetWorldPosition(0,height),GetWorldPosition(width,height),Color.white,100f);
        Debug.DrawLine(GetWorldPosition(width,0),GetWorldPosition(width,height),Color.white,100f);

        SetValue(2,1,56);
    }

    private Vector3 GetWorldPosition(int x,int y){
        return new Vector3(x,y)*cellSize;
    }

    public void SetValue(int x,int y, int value){
        if (x >=0 && y>=0 && x<width && y<height){
            gridArray[x,y] = value;
            debugTextArray[x,y].text = gridArray[x,y].ToString();
        }
    }
}