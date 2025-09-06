using JJORY.Util;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;


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

            login_Button.onClick.AddListener(OnClickLoginButton);
        }
        #endregion

        #region Method
        private void Init()
        {
            account_InputField.inputType = TMP_InputField.InputType.Standard;
            password_InputField.inputType = TMP_InputField.InputType.AutoCorrect;
            password_InputField.contentType = TMP_InputField.ContentType.Autocorrected;
        }

        private void OnClickLoginButton()
        {
            if (account_InputField.text.Equals(account_Admin) && password_InputField.text.Equals(password_Admin))
            {
                Utils.CreateLogMessage<UI_LoginSceneController>("�α��� ����");
            }
            else if(account_InputField.text.Equals(account_Admin) == false)
            {
                Utils.CreateLogMessage<UI_LoginSceneController>("��ī��Ʈ ���� ����");
            }
            else if(account_InputField.text.IsNullOrEmpty())
            {
                Utils.CreateLogMessage<UI_LoginSceneController>("��ī��Ʈ ���Է�");
            }
            else if (password_InputField.text.Equals(password_Admin) == false)
            {
                Utils.CreateLogMessage<UI_LoginSceneController>("��й�ȣ ���� ����");
            }
            else if (password_InputField.text.IsNullOrEmpty())
            {
                Utils.CreateLogMessage<UI_LoginSceneController>("��й�ȣ ���Է�");
            }
        }

        private void OnClickRegistButton()
        {

        }
        #endregion
    }
}
