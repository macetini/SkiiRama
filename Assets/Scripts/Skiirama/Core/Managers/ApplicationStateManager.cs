using Assets.Scripts.Skiirama.Core.Common;
using UnityEngine;

namespace Assets.Scripts.Skiirama.Core.Managers
{
    public class ApplicationStateManager : MonoBehaviour
    {
        public ApplicationState CurrentState = ApplicationState.Application;
        public ApplicationState PreviousState { get; private set; }
    }
}