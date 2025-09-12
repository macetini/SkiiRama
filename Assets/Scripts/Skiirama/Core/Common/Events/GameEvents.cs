namespace Assets.Scripts.Skiirama.Core.Common.Events
{
    public class GameEvents
    {
        public delegate void GameEvent();
        public static event GameEvent OnMainGameEvent;
        public static void InvokeMainGameEvent()
        {
            OnMainGameEvent?.Invoke();
        }
    }
}