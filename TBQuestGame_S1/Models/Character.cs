﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame_S1.Models
{
   public class Character
    {
        #region Enums
        public enum CharacterTitle
        {
            Imperator,
            Praetor,
            Centurion,
            Praetorian,
            Cavalry,
            Archer,
            Legionnaire
        }
        #endregion

        #region Fields
        private int _id;
        private string _name;
        private CharacterTitle _title;
        private int _rank;
        private int _attack;
        private int _defense;
        #endregion

        #region Properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public CharacterTitle Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }
        #endregion

        #region Constructors

        public Character()
        {

        }

        public Character(string name, CharacterTitle title, int rank, int attack, int defense)
        {
            _name = name;
            _title = title;
            _rank = rank;
            _attack = attack;
            _defense = defense;
        }

        #endregion
    }
}
