using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public  class RoomTemplateBuilderDel : RoomTemplateBuilder {
    
    [MenuItem ("VAIV/CreateWorks/Build Room Template")]
    public static void CmdBuildActiveScene () {
        new RoomTemplateBuilderDel().BuildActiveScene();
    }
}