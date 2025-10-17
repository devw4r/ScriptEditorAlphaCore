using System;

namespace ScriptEditor
{
    public class LoadingAction
    {
        public Action Action;
        public string IndicatorText;

        public LoadingAction(Action action, string indicatorText)
        {
            Action = action;
            IndicatorText = indicatorText;  
        }
    }
}