namespace Assets.Scripts.Skiirama.Core.Managers.UI
{
    public class UIStateEvents
    {
        public delegate void UIStateEvent();

        public static event UIStateEvent OnShowLoadingStateEvent;
        public static void InvokeShowLoadingStateEvent()
        {
            OnShowLoadingStateEvent?.Invoke();
        }

        public static event UIStateEvent OnLoadingStateEvent;
        public static void InvokeLoadingStateEvent()
        {
            OnLoadingStateEvent?.Invoke();
        }
    }
}
