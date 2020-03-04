using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGame_S1.Models;

namespace TBQuestGame_S1.DataLayer
{
    class GameData
    {
        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Spartacus",
                PlayerGender = Player.Gender.male,
                Title = Character.CharacterTitle.Praetor,
                PlayerStartStyle = Player.StartStyle.neutral,
                Attack = 500,
                Defense = 500,
                Rank = 1000
            };
        }

        public static List<string> InitialMessage()
        {
            return new List<string>()
            {
                "Welcome to Mundas, a land that is ravaged by waring factions and barbarian hordes." +
                "You are an Imperator, a high ranking general, of the Aquila Empire." +
                "You have been tasked by your Emperor and the High Council to lay seige on enemy fortresses." +
                "Along with the title of Imperator, you have been given a legion and a starting sum of gold." +
                "Use your newfound status and wealth wisely. The Emperor will not tolerate failure."
            };
        }
    }
}
