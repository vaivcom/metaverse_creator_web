using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEditor.SceneTemplate;
using UnityEngine;

public class RoomTemplateCreatorDel :  RoomTemplateCreator {

    [MenuItem ("VAIV/CreateWorks/Create Room Template")]
    public static void CmdCreateRoomTemplate () {
        new RoomTemplateCreatorDel().CreateRoomTemplate();
    }

    override protected  ResourceDescriptor CreateResourceDescrior () {
       return ScriptableObject.CreateInstance<ResourceDescriptorDel> ();
    }
}