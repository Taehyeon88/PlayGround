using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTween2 : MonoBehaviour
{
    private bool isPunch = false;
    
    private Renderer renderer;
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Shift))
        {
            if(!isPunch)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPuch);
            }
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Color color = new Color(Random.value, Random.value, Random.value);

            renderer .material.DOColor(color, 1f)
                .SetEase(Ease.InOutQuad)
                .SetAutoKill(false)
                .Pause()
                .OnComplete(() => Debug.Log("Colorº¯È¯ ¿Ï·á"));
                renderer.material.DOPlay();
    }
    void EndPuch()
    {
        isPunch = false;
    }
}
