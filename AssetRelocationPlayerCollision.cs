
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class AssetRelocationPlayerCollision : UdonSharpBehaviour
{
    public GameObject[] objects; // Array of Objects
    public GameObject[] placements; // Array of Locations

    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        // Assuming Order of Objects & Locations match.
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].transform.position = placements[i].transform.position;
            objects[i].transform.rotation = placements[i].transform.rotation;
        }
    }
}
