using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange_to_lectureroom : MonoBehaviour
{
    // 충돌을 검출할 때 실행되는 메서드
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트가 메인 카메라인지 확인
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            // 원하는 씬의 이름으로 바꿔주세요.
            string sceneName = "lectureroom_design";

            // 해당 씬으로 이동
            SceneManager.LoadScene(sceneName);
        }
    }
}