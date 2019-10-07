using System.Data.Linq.Mapping;

namespace Linq_To_Objects
{
    [Table(Name = "Film")]

    public class ClassFilm
    {
        private int _filmid;
        private string _titel;
        private string _land;
        private int _year;
        private string _genre;
        private int _oscars;

        public ClassFilm()
        {

        }

        [Column(IsPrimaryKey = true, Storage = "_filmid")]
        public int filmid
        {
            get { return _filmid; }
            set { _filmid = value; }
        }

        [Column(Storage = "_titel")]
        public string titel
        {
            get { return _titel; }
            set
            {
                if (_titel != value)
                {
                    _titel = value;
                }
            }
        }

        [Column(Storage = "_land")]
        public string land
        {
            get { return _land; }
            set
            {
                if (_land != value)
                {
                    _land = value;
                }
            }
        }

        [Column(Storage = "_year")]
        public int year
        {
            get { return _year; }
            set
            {
                if (_year != value)
                {
                    _year = value;
                }
            }
        }

        [Column(Storage = "_genre")]
        public string genre
        {
            get { return _genre; }
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                }
            }
        }

        [Column(Storage = "_oscars")]
        public int oscars
        {
            get { return _oscars; }
            set
            {
                if (_oscars != value)
                {
                    _oscars = value;
                }
            }
        }



    }
}
