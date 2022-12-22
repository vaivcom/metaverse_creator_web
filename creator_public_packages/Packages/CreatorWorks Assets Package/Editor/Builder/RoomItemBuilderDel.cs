using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class RoomItemBuilderDel : RoomItemBuilder {
    [MenuItem ("Assets/VAIV/Build Room Item", true, 10)]
    public static bool CmdSelectedObjectValid () {
        return new RoomItemBuilderDel ().BuildSelectedObjectValid ();
    }

    [MenuItem ("Assets/VAIV/Build Room Item", false, 10)]
    public static void CmdSelectedObject () {
        new RoomItemBuilderDel ().BuildSelectedObject ();
    }
}