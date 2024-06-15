using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;



public class cargar_imagenes : MonoBehaviour



{
    public Material myMaterial;
    public RawImage[] myRawImages; // Array of RawImage components
    public string[] imageUrls; // List of image URLs

  



    void Start()
    {
        StartCoroutine(DownloadImages());
    }

    IEnumerator DownloadImages()
    {
        for (int i = 0; i < imageUrls.Length; i++)
        {
            string url = imageUrls[i];
            yield return DownloadImageFromURL(url, i);
        }
    }

    IEnumerator DownloadImageFromURL(string url, int index)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);

        yield return request.SendWebRequest();

        if (request.result == UnityWebRequest.Result.Success)
        {
            Texture downloadedTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;

            myRawImages[index].texture = downloadedTexture;
            myMaterial.mainTexture = downloadedTexture; // Set the material texture only if needed
        }
        else
        {
            Debug.LogError($"Failed to download image from {url}: {request.error}");
        }
    }
}
