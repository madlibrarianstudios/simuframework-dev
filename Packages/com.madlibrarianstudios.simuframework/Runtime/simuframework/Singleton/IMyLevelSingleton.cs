// namespace mygamemanager
// {




    public interface IMyLevelSingleton
    {


        bool isLevelRunning { get; set; }
        void LoadLevel(int asLevelNumber);
        void UnLoadLevel();
        void StartLevel();
        // void PlayerHasWonLevel();
        void PlayerHasDied();
        // void PlayerRespawned();

        void RestartLevel();

         }
// }