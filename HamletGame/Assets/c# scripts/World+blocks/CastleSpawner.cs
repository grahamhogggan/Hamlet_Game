using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSpawner : MonoBehaviour
{
    private static int spacing = 14;
    private static int seed = 1729;
    public static Spawner world;

    // Start is called before the first frame update
    public static void Do()
    {
        Block originBlock = world.GetBlock(40, 40, 40);
        SpawnCastle(originBlock);
    }
    private static void SpawnCastle(Block origin)
    {
        BlockChange spawn = StructureManager.GetStructure("castle");
        Chunk c = origin.getChunk();
        Vector3 offset = origin.GetLocalPos() + new Vector3(-2, 0, -2);
        c.ApplyAlternateChanges(spawn, offset, 0);
    }

}