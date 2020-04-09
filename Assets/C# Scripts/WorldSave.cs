using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;

public class TileData
{
    string type;
    int tile;
    JsonData a;

    public string GetMeta(string path)
    {
    }
}

public class RowData
{
    Dictionary<int, TileData> data;
}


public class WorldData
{
    List<TileData> tiles;
}

public class world
{
    WorldData w;
    public world()
    {
        
    }
    
    TileData GetTileData(int x, int y)
    {

    }
}
