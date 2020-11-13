using System;
using System.Collections.Generic;
using System.Text;

namespace UtmaningEtt
{
    class Platform
    {
        public int id { get; set; }

        public int publisher_id { get; set; }

        public string name { get; set; }

        public int max_players { get; set; }

        public bool is_handheld { get; set; }

        public List<Game> Games { get; set; }
    }

    class Game
    {
        public int id { get; set; }

        public int platform_id { get; set; }

        public int publisher_id { get; set; }

        public string name { get; set; }

        public int release_year { get; set; }

        public float cost { get; set; }

        public List<Platform> Platforms { get; set; }
        public List<Publisher> Publishers { get; set; }
    }

    class Publisher
    {
        public int id { get; set; }

        public string name { get; set; }

        public string country { get; set; }

        public double net_worth { get; set; }
    }
}
