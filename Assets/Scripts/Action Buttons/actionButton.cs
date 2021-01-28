using UnityEngine;

public class actionButton : MonoBehaviour
{
    UpperContent upperContent;

    void Start()
    {
        upperContent = new UpperContent();
    }
    public void onMouseClick()
    {
        
        upperContent.insertActionButton(this.tag);
    }

    
}
