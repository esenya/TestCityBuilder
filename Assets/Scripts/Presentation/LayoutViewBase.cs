using UnityEngine;
using UnityEngine.UIElements;

namespace Presentation
{
    [RequireComponent(typeof(UIDocument))]
    public abstract class LayoutViewBase : MonoBehaviour
    {
        protected VisualElement root;
        protected UIDocument uiDocument;

        public virtual void Awake()
        {
            uiDocument = GetComponent<UIDocument>();
            root = uiDocument.rootVisualElement;
        }
    }
}