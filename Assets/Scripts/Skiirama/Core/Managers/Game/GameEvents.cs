namespace Assets.Scripts.Skiirama.Core.Managers.Game
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