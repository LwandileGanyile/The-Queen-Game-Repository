using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Queen
{
    public class Player
    {
        private string _playerName;
        private string _playerSurname;
        private int _playerId;
        private float _playerMark;

        public Player()
        {

        }

        public Player(string _playerName,string _playerSurname,int _playerId)
        {
            this._playerId = _playerId;
            this._playerName = _playerName;
            this._playerSurname = _playerSurname;
            _playerMark = 0;

        }

        public Player(string _playerName, string _playerSurname, int _playerId,float _playerMark)
        {
            this._playerId = _playerId;
            this._playerName = _playerName;
            this._playerSurname = _playerSurname;
            this._playerMark = _playerMark;

        }

        public string PlayerName { get; set; }

        public string PlayerSurname { get; set; }

        public int PlayerId { get; set; }

        public float PlayerMark { get; set; }

        public void DecreaseMark(float amount)
        {

        }

        public void IncreaseMark(float amount)
        {

        }

    }
}
