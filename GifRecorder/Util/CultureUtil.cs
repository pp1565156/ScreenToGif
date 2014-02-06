﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenToGif.Util
{
    public static class CultureUtil
    {
        private static string _lang;

        /// <summary>
        /// The current UI language.
        /// </summary>
        public static string Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }
    }
}
