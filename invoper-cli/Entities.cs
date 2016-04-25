using System;
using System.Collections.Generic;
using System.Text;

namespace invoper_cli
{
    public class Entities
    {
        public class Language
        {
            private int _id;
            private string _name;
            private string _isoName;
            private string _file;

            public int Id
            {
                get
                {
                    return _id;
                }

                set
                {
                    _id = value;
                }
            }

            public string Name
            {
                get
                {
                    return _name;
                }

                set
                {
                    _name = value;
                }
            }

            public string IsoName
            {
                get
                {
                    return _isoName;
                }

                set
                {
                    _isoName = value;
                }
            }

            public string File
            {
                get
                {
                    return _file;
                }

                set
                {
                    _file = value;
                }
            }
        }

        public class Configuration
        {
            public string IsoName;
            public string File;
            public string LanguageName;
        }

    }
}
