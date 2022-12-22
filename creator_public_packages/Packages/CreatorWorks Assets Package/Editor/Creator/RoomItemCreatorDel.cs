using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class RoomItemCreatorDel : RoomItemCreator {
    [MenuItem ("Assets/VAIV/Create Room Item", true, 10)]
    public static bool CmdCreateSelectedObjectValid () {
        return new RoomItemCreatorDel ().CreateSelectedObjectValid ();
    }

    [MenuItem ("Assets/VAIV/Create Room Item", false, 10)]
    public static void CmdCreateSelectedObject () {
        new RoomItemCreatorDel ().CreateSelectedObject ();
    }
}