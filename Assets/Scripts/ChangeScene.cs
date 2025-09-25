using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void GoToFloorPlanOptions()
    {
        SceneManager.LoadScene("FloorPlanOptions");
    }
    public void GoToFloorPlan1()
    {
        SceneManager.LoadScene("FloorPlan1");
    }
    public void GoToFloorPlan2()
    {
        SceneManager.LoadScene("FloorPlan2");
    }
}
