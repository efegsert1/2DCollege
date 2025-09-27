using UnityEngine;

public class KeyTest : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("스페이스를 눌렀습니다");
        }

        if(Input.GetKeyUp(KeyCode.J))
        {
            Debug.Log("J를 눌렀습니다.");
        }
    }
}
