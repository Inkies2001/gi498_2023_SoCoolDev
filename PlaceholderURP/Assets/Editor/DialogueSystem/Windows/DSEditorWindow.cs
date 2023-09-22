using UnityEditor;
using UnityEngine.UIElements;

namespace DS.Windows
{
    using Utilities;
    public class DSEditorWindow : EditorWindow
    {
        [MenuItem("Window/DS/Dialogue Graph")]
        public static void ShowExample()
        {
            GetWindow<DSEditorWindow>("Dialogue Graph");
        }

        private void CreateGUI()
        {
            AddGraphView();

            AddStyles();
        }

        #region Element Addition
        
        private void AddGraphView()
        {
            DSGraphView graphView = new DSGraphView(this);

            graphView.StretchToParentSize();

            rootVisualElement.Add(graphView);
        }

        private void AddStyles()
        {
            rootVisualElement.AddStyleSheets(
                "DialogueSystem/DSVariable.uss"
            );
        }
        
        #endregion
    }
}
