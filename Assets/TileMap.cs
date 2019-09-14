using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour {

    //Array of the different tile types, for easy reference using ints in tiles array.
    TileType[] tileTypes;

    //2d array of ints that will be used to reference tileTypes and build a map
    int[,] tiles;

    //Map sizes easily changed
    int mapSizeX = 10;
    int mapSizeY = 10;

    void Start()
    {
        //Initialize tiles array.
        tiles = new int[mapSizeX, mapSizeY];

        //Nested for loop fills out tiles array to build room
        for(int i = 0; i < mapSizeX; i++)
        {
            for(int j = 0; j < mapSizeY; j++)
            {
                tiles[i, j] = 0;
            }
        }
    }

}
