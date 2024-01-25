namespace Raichu
{
    public class AppState
    {
        public event Action OnChange;

        private string _applicationState;

        public string ApplicationState
        {
            get => _applicationState;
            set
            {
                if (_applicationState != value)
                {
                    _applicationState = value;
                    NotifyStateChanged();
                }
            }
        }

        public void NotifyStateChanged() => OnChange?.Invoke();
    }
}
