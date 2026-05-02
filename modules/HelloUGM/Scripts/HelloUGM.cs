using UnityEngine;

namespace UGM.Modules.HelloUGM
{
    /// <summary>
    /// UGM E2E 검증용 더미 컴포넌트.
    /// PlayMode 진입 시 콘솔에 메시지를 출력한다. 임포트가 정상적으로 됐고
    /// 컴파일이 통과했음을 확인하는 용도.
    /// </summary>
    public class HelloUGM : MonoBehaviour
    {
        [SerializeField] private string message = "Hello UGM! 더미 모듈이 정상적으로 임포트되어 동작합니다.";

        private void Start()
        {
            Debug.Log($"[UGM:HelloUGM] {message}");
        }
    }
}
