using JJORY.Module;
using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;


namespace JJORY.Controller.Scene
{
    public class BaseSceneController : MonoBehaviour
    {
        #region Method
        /// <summary>
        /// Addressable Asset ���� ó�� �޼���
        /// </summary>
        /// <param name="_key">Addressable ��� key</param>
        /// <param name="_parent">��ġ ���� �θ� ������Ʈ</param>
        /// <returns></returns>
        protected IEnumerator InstantiateAsset(string _key, GameObject _parent)
        {
            AsyncOperationHandle handler;

            while (!AddressableController.Instance.GetHandler(_key, out handler))
            {
                yield return null;
            }

            // �ε� �Ϸ�� ������ ���
            while (!handler.IsDone)
            {
                yield return null;
            }

            GameObject prefab = handler.Result as GameObject;
            GameObject go = AddressableController.Instance.InstantiatePrefab(_key, prefab);
            go.transform.parent = _parent.transform;
        }
        #endregion
    }
}