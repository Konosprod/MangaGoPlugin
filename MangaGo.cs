using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MangaDownloader;

namespace MangaGo
{
    public class MangaGo : MangaPlugin
    {
        private Manga _Manga;

        public Manga Manga
        {
            get
            {
                return _Manga;
            }
        }
        public String Version
        {
            get
            {
                return "1.0";
            }
        }
        public String Creator
        {
            get
            {
                return "Kono";
            }
        }
        public String Name
        {
            get
            {
                return "MangaGo";
            }
        }

        public String Url
        {
            get
            {
                return "http://www.mangago.me/";
            }
        }
    }
}
