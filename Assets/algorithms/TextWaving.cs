
/*
 
Written by Andrew Pozenel AKA SloDevTeam - .:VOID:. - 2020-2022
 
 */

#region Imports

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.IO;

#endregion

public class TextWaving : MonoBehaviour


{

    #region Input properties

    public TMP_Text textComponent;

    #endregion



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame


    #region Waving Author text

    void Update()
    {


        textComponent.ForceMeshUpdate();
        var textInfo = textComponent.textInfo;

        for (int i = 0; i < textInfo.characterCount; ++i)
        {
            var charInfo = textInfo.characterInfo[i];

            if (!charInfo.isVisible)
            {
                continue;
            }

            var verts = textInfo.meshInfo[charInfo.materialReferenceIndex].vertices;

            for (int j = 0; j < 4; ++j)
            {
                var orig = verts[charInfo.vertexIndex + j];
                verts[charInfo.vertexIndex + j] = orig + new Vector3(0, Mathf.Sin(Time.time * 2f + orig.x * 0.01f) * 10f, 0);

            }


            for (int k = 0; k < textInfo.meshInfo.Length; ++k)
            {
                var meshInfo = textInfo.meshInfo[k];
                meshInfo.mesh.vertices = meshInfo.vertices;
                textComponent.UpdateGeometry(meshInfo.mesh, k);
            }



        }

        
    }

    #endregion

}
