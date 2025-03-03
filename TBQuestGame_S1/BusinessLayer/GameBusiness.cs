﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame_S1.Models;
using TBQuestGame_S1.DataLayer;
using TBQuestGame_S1.PresentationLayer;

namespace TBQuestGame_S1.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        Player _player = new Player();
        List<string> _messages;
        bool _newPlayer = true;
        PlayerSetupView _playerSetupView;

        public GameBusiness()
        {
            SetupPlayer();
            InitializeDataSet();
            InstantiateAndShowView();
        }

        /// <summary>
        /// Initialize data set
        /// </summary>
        private void InitializeDataSet()
        {
            _messages = GameData.InitialMessage();
        }

        /// <summary>
        /// Initiate the view
        /// </summary>
        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(_player, _messages);
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            _playerSetupView.Close();
        }

        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetupView = new PlayerSetupView(_player);
                _playerSetupView.ShowDialog();
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }
    }
}
