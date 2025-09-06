using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace JJORY.Controller.UI
{
    public class UI_LoginSceneController : MonoBehaviour
    {
        #region Variable
        [Header("UI ����")]
        [SerializeField] private TMP_InputField account_InputField;
        [SerializeField] private TMP_InputField password_InputField;
        [SerializeField] private Button regist_Button;
        [SerializeField] private Button login_Button;

        [Header("���� ���� ����")]
        [SerializeField] private string account_Value;
        [SerializeField] private string password_Value;

        [Header("�α��� �׽�Ʈ ���� ����")]
        [SerializeField] private string account_Admin = "admin";
        [SerializeField] private int password_Admin = 1234;
        #endregion

        #region LifeCycle
        private void Start()
        {
            Init();
        }
        #endregion

        #region Method
        private void Init()
        {
            account_InputField.inputType = TMP_InputField.InputType.Standard;
            password_InputField.inputType = TMP_InputField.InputType.AutoCorrect;
        }

        private void OnClickLoginButton()
        {

        }

        private void OnClickRegistButton()
        {

        }
        #endregion
    }
}
