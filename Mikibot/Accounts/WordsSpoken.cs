﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miki.Accounts
{
    /* Work in progress, funny command to check how many times <DiscordMember> said <FilterWords> in chat */
    public class WordsSpoken
    {
        string[] FilterWords;
        public int MessagesSent;

        public void Initialize()
        {
            FilterWords = GetWordsFromFile();
        }

        string[] GetWordsFromFile()
        {
            return null;
        }
    }
}