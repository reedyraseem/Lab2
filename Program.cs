namespace Lab_2
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;



    class VideoGame
    {
        public string Title { get; set; }
        public string Platform { get; set; }
        public double GlobalSales { get; set; }

        public VideoGame(string title, string platform, double globalSales)
        {
            Title = title;
            Platform = platform;
            GlobalSales = globalSales;
        }
    }
    class Program
    {
        static void Main()
        {
            // VideoGame List
            List<VideoGame> games = new List<VideoGame>
        {
            new VideoGame("FIFA 17", "PS4", 4.77),
            new VideoGame("Tom Clancy's The Division", "Xone", 2.01),
            new VideoGame("NBA 2K17", "PS4", 1.19),
            new VideoGame("MLB 16", "PS4", 0.84),
            
            new VideoGame("Tom Clancy's The Division", "Xone", 2.01),
            new VideoGame(" Phantasy Star Online 2 Episode 4: Deluxe Packackage", "PS4", 0.03),
            new VideoGame("Far Cry: Primal", "PS4", 2.13),
            new VideoGame("FIFA 17", "Xone", 1.53),
            new VideoGame("NBA 2K17", "Xone", 0.64),
            new VideoGame("Doom", "Xone", 0.69),
            new VideoGame("UFC 2", "Xone", 0.4),
            new VideoGame("FIFA 17", "Xone", 1.53),

            new VideoGame("Phantasy Star Online 2 Episode 4:", "PSV", 0.01),
            new VideoGame("Brothers Conflict: Precious Baby", "PSV", 0.01),
            new VideoGame("Kan Colle Kai", "PSV", 0.19),
            new VideoGame("Jikkyou Powerful Pro Baseball 2016", "PSV", 0.17),
            new VideoGame("LEGO Marvel's Avengers", "PSV", 0.23),

            new VideoGame("Yokai Watch 3", "3DS", 1.27),
            new VideoGame("Kirby: Planet Robobot", "3DS", 0.85),
            new VideoGame("Dragon Quest Monsters Joker 3", "3DS", 0.63),
            new VideoGame("Yokai Sangokush", "3DS", 0.55),
            new VideoGame("Hyrule Warriors", "3DS", 0.42),

            new VideoGame("Overwatch", "PC", 0.43),
            new VideoGame("Tom Clancy's The Division", "PC", 0.37),
            new VideoGame("XCOM 2", "PC", 0.2),
            new VideoGame("World of Warcraft: Legion", "PC", 0.29),
            new VideoGame("Doom", "PC", 0.18),

            new VideoGame("Minecraft", "WiiU", 0.43),
            new VideoGame("Star Fox: Zero", "WiiU", 0.35),
            new VideoGame("Mario & Sonic at the Rio 2016 Olympic Games", "WiiU", 0.26),
            new VideoGame("LEGO Marvel's Avengers", "WiiU", 0.23),
            new VideoGame("Lego Star Wars: The Force Awakens", "WiiU", 0.09),


            new VideoGame("FIFA 17", "X360", 0.18),
            new VideoGame("Lego Star Wars: The Force Awakens", "X360", 0.08),
            new VideoGame("Madden NFL 17", "X360", 0.08),
            new VideoGame("NBA 2K17", "X360", 0.05),
            new VideoGame("Teenage Mutant Ninja Turtles: Mutants in Manhattan", "X360", 0.03),
            new VideoGame("Rugby Challenge 3", "X360", 0.02),


             new VideoGame("LEGO Marvel's Avengers", "PS3", 0.32),
              new VideoGame(" Dragon Quest Builders: Revive Alefgard", "PS3", 0.12),
              new VideoGame("Yakuza Kiwami", "PS3", 0.12),
               new VideoGame("UEFA Euro 2016", "PS3", 0.01),
                new VideoGame("Jikkyou Powerful Pro Baseball 2016", "PS3", 0.11),


             new VideoGame("Yard Sale Hidden Treasures: Sunnyville", "DS", 0.12),
              new VideoGame("Pokemon Mystery Dungeon: Explorers of Sky", "DS", 1.58),
              new VideoGame("Phineas and Ferb", "DS", 1.86),
               new VideoGame("Kingdom Hearts 358/2 Days", "DS", 2.04),
                new VideoGame("Scribblenauts", "DS", 2.22),

              new VideoGame("Making History: The Great War", "PSP", 0.12),
              new VideoGame("LittleBigPlane", "PSP", 2.58),
              new VideoGame("Kazoku Keikaku", "PSP", 0.02),
              new VideoGame("Secret Game Portable", "PSP", 0.01),
              new VideoGame("Gran Turismo", "PSP", 3.27),

              new VideoGame("Rival Schools: United By Fate", "PS", 0.52),
              new VideoGame("Wu-Tang: Shaolin Style", "PS", 0.48),
              new VideoGame("NCAA Gamebreaker 99", "PS", 0.45),
              new VideoGame("World Stadium 2", "PS", 0.45),
              new VideoGame("Apocalypse", "PS", 0.45),

              new VideoGame("Super Robot Taisen F Kanketsuhen", "SAT", 0.55),
               new VideoGame("Sakura Taisen 2 - Kimi Shinitamou Koto Nakare", "SAT", 0.53),
               new VideoGame("Kidou Senshi Gundam: Giren no Yabou", "SAT", 0.25),
               new VideoGame("Pro Yakyuu Team o Tsukurou", "SAT", 0.25),
               new VideoGame("Eve: The Lost One", "SAT", 0.16),

               new VideoGame("All-Star Baseball 99", "N64", 0.48),
                new VideoGame("NBA Live 99", "N64", 0.47),
                 new VideoGame("Bomberman Hero", "N64", 0.47),
                 new VideoGame("Quest 64,", "N64", 0.47),
                 new VideoGame("FIFA 99", "N64", 0.54),


                  new VideoGame("Super Mario Land", "GB", 18.14),
                   new VideoGame("Baseball", "GB", 1.61),
                    new VideoGame("Yakuman", "GB", 1.28),
               new VideoGame("SolarStriker", "GB", 1.2),
                 new VideoGame("The Final Fantasy Legend", "GB", 1.1),




                   new VideoGame("World Class Rugby 2: Kokunai Gekitou Hen '93", "SNES", 0.02),
                   new VideoGame("Super Mario All-Stars", "SNES", 10.55),
                   new VideoGame("Star Fox", "SNES", 2.99),
                   new VideoGame("Mortal Kombat II", "SNES", 1.93),
                   new VideoGame("Secret of Mana", "SNES", 1.83),


               new VideoGame("Madden NFL 08", "XB", 0.18),
               new VideoGame("Van Helsing", "XB", 0.18),
               new VideoGame("NCAA 08", "XB", 0.08),
               new VideoGame("NCAA 07", "XB", 0.56),
               new VideoGame("The Godfather", "XB", 0.55),
               new VideoGame("FIFA Soccer 07", "XB", 0.54),

               new VideoGame("WordJong Party", "Wii", 0.18),
                new VideoGame("Castlevania Judgment", "Wii", 0.18),
                 new VideoGame("Goosebumps HorrorLan", "Wii", 0.17),
                  new VideoGame("Professor Heinz Wolff's Gravity", "Wii", 0.17),
                new VideoGame("NCAA Football 09 All-Play", "Wii", 0.17),




                 new VideoGame("Adventure of Lolo","NES", 0.06),
                 new VideoGame("Super Mario Bros. 3","NES", 17.28),
                 new VideoGame("Super Mario Bros. 2","NES", 7.46),
                 new VideoGame("Dragon Warrior III","NES", 3.87),
                 new VideoGame("Ice Hockey","NES", 2.42),


                 new VideoGame("Double Dragon","2600", 0.47),
                  new VideoGame("River Raid II","2600", 0.51),
                     new VideoGame("Rampage","2600", 0.24),
                     new VideoGame("Kung-Fu Master,","2600", 0.65),
                    new VideoGame("Commando","2600", 0.47),







                  new VideoGame("Klax","Atari", 0.15),
                   new VideoGame("Defender II","Atari", 0.45),
                    new VideoGame("Desert Falcon","Atari", 0.26),
                     new VideoGame("Super Football","Atari", 0.08),
                      new VideoGame("Super Baseball","Atari", 0.07),


            // Add more games as needed
        };

            // Group games by platform using LINQ
            //Dictonary String with Groupby
            Dictionary<string, List<VideoGame>> gamesByPlatform = games
                .GroupBy(videogame => videogame.Platform)
                .ToDictionary(group => group.Key, group => group.ToList());

            // Lambda/Arrow function
            Func<string, List<VideoGame>> getTop5GamesByPlatform = (platform) =>
            {
                if (gamesByPlatform.ContainsKey(platform))
                {
                    return gamesByPlatform[platform]
                        .OrderByDescending(videogame => videogame.GlobalSales)
                        .Take(5)
                        .ToList();
                }
                else
                {
                    return new List<VideoGame>(); // Platform not found
                }
            };

            //Top five Videogames on each  platform
            foreach (var platform in gamesByPlatform.Keys)
            {
                Console.WriteLine($"Top 5 Games for {platform}:");
                List<VideoGame> top5Games = getTop5GamesByPlatform(platform);
                foreach (var videogame in top5Games)
                {
                    Console.WriteLine($"Title: {videogame.Title}, Global Sales: {videogame.GlobalSales}");
                }
                Console.WriteLine();
            }
        }
    }
}

