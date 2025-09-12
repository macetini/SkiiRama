namespace Assets.Scripts.Skiirama.Core.Managers.Events
{
    public class GameStateEvents
    {
        public delegate void GameStatesEvent();

        public static event GameStatesEvent OnMainStateEvent;
        public static void InvokeSetMainStateEvent()
        {
            OnMainStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnStartStateEvent;
        public static void InvokeSetStartStateEvent()
        {
            OnStartStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnActiveStateEvent;
        public static void InvokeSetActiveStateEvent()
        {
            OnActiveStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnPassStateEvent;
        public static void InvokeSetPassStateEvent()
        {
            OnPassStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnFailStateEvent;
        public static void InvokeSetFailStateEvent()
        {
            OnFailStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnImmobileStateEvent;
        public static void InvokeSetImmobileStateEvent()
        {
            OnImmobileStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnResetStateEvent;
        public static void InvokeSetResetStateEvent()
        {
            OnResetStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnTransitionStateEvent;
        public static void InvokeSetTransitionStateEvent()
        {
            OnTransitionStateEvent?.Invoke();
        }

        public static event GameStatesEvent OnQuitStateEvent;
        public static void InvokeSetQuitStateEvent()
        {
            OnQuitStateEvent?.Invoke();
        }
    }
}