using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange_to_lectureroom : MonoBehaviour
{
    // �浹�� ������ �� ����Ǵ� �޼���
    private void OnCollisionEnter(Collision collision)
    {
        // �浹�� ������Ʈ�� ���� ī�޶����� Ȯ��
        if (collision.gameObject.CompareTag("MainCamera"))
        {
            // ���ϴ� ���� �̸����� �ٲ��ּ���.
            string sceneName = "lectureroom_design";

            // �ش� ������ �̵�
            SceneManager.LoadScene(sceneName);
        }
    }
}