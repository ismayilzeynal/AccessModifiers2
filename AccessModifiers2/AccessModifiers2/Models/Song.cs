using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2.Models
{
    class Song
    {
        //fields
        private string _name;
        private string _genre;
        private float _avgRating = 0;
        private int _countOfVotes = 0;

        //props
        public Singer Singer { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 101)
                    _name = value;
            }
        }

        public string Genre
        {
            get => _genre;
            set
            {
                if (value == "Pop" || value == "Rock" || value == "Jazz" || value == "Techno")
                    _genre = value;
            }
        }



        //Methods
        public void Addrating(float Rate)
        {
            if (Rate > 10)          // if anyone wants to give a high rating, let's just take the maximum (10) for user experience 
            {
                Rate = 10;
            }

            _countOfVotes++;
            _avgRating = ((_countOfVotes - 1) * _avgRating + Rate) / _countOfVotes;      // new rating 
        }

        public float GetAverageRating()      // public float GetAverageRating { get => _avgRating; }  // ---- I think we can use like prop too
        {
            return _avgRating;
        }



        // ctor
        public Song()
        {

        }
        public Song(string name)
        {
            Name = name;
        }
        public Song(string name, string genre):this(name)
        {
            Genre = genre;
        }


    }
}
