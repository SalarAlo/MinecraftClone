using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirLayerHandler : SingleBlockLayerHandler
{
    public AirLayerHandler(BlockType blockType) : base(blockType) { }

    public override bool ShouldPlace(ChunkData chunkData, Vector3Int pos, int surfaceHeightNoise, Vector2Int mapSeed) => pos.y > surfaceHeightNoise;
}
