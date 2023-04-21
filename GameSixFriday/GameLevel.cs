using System;


namespace GameSix.GameSixFriday
{
    public class GameLevel
    {
        private int        roomCount;
        private Difficulty difficulty;
        private Foe[]      foes;
        private int        foeCount;


        public GameLevel(int rooms, Difficulty diff)
        {
            roomCount = rooms;
            difficulty = diff;
            foeCount = 0;
            foes = new Foe[rooms];
        }


        public void SetFoeInRoom(int roomIndex, Foe foe)
        {
            if(foes[roomIndex] == null) foeCount++;

            foes[roomIndex] = foe;
        }


        public Difficulty GetDifficulty()
        {
            return difficulty;
        }


        public int GetNumRooms()
        {
            return roomCount;
        }


        public int GetNumFoes()
        {
            return foeCount;
        }


        public void PrintFoes()
        {
            for(int i = 0; i < foes.Length; i++)
            {
                if(foes[i] == null) continue;

                Console.WriteLine($"Room {i + 1}: {foes[i].GetName()}");
            }
        }
    }
}