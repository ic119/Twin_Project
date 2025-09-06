using JJORY.Module;
using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;


namespace JJORY.Controller.Scene
{
    public class LoginSceneController : BaseSceneController
    {
        #region Variable
        #endregion

        #region LifeCycle
        private void Awake()
        {
            AddressableController.Instance.LoadPrefab<GameObject>("UI_LoginScene");
        }

        private void Start()
        {
            StartCoroutine(InstantiateAsset("UI_LoginScene", this.gameObject));
        }
        #endregion

        #region Method
        #endregion
    }
}