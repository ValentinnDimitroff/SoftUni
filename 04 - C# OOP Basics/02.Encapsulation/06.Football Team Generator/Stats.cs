namespace FootballTeamGenerator
{
    using System;

    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Shooting
        {
            get { return this.shooting; }
            set
            {
                if (value < 0 && value > 100)
                {
                    throw new ArgumentException($"{nameof(Shooting)} should be between 0 and 100."); 
                }
                this.shooting = value;
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Endurance)} should be between 0 and 100.");
                }
                this.endurance = value;
            }
        }

        public int Passing
        {
            get { return passing; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Passing)} should be between 0 and 100.");
                }
                passing = value;
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Dribble)} should be between 0 and 100.");
                }
                this.dribble = value;
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{nameof(Sprint)} should be between 0 and 100.");
                }
                this.sprint = value;
            }
        }

        public double GetAverageStats()
        {
            var statsSum =  this.Dribble + this.Endurance + this.Passing + this.Sprint + this.Shooting;
            return statsSum / 5.0;
        }
    }
}
