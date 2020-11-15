/****************************************************
    文件：ImportFileAutoSetter.cs
	作者：积极向上小木木
    邮箱: positivemumu@126.com
    日期：2020/11/11 23:11:26
	功能：Nothing
*****************************************************/

using UnityEngine;
using UnityEditor;

public class ImportFileAutoSetter : AssetPostprocessor 
{
    private void OnPreprocessTexture()
    {
        TextureImporter texture = (TextureImporter)assetImporter;

        texture.filterMode = FilterMode.Point;
        texture.textureCompression = TextureImporterCompression.Uncompressed;
        texture.spritePixelsPerUnit = 32f;
        texture.maxTextureSize = 32;
    }
}