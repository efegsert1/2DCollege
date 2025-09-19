using UnityEngine;

public class ScrollScripts : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("텍스쳐의 스크롤 설정")]
    public float scrollSpeed;

    [Header("References")]
    public MeshRenderer mr;
    void Start()
    {
        
    }

   
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
