﻿using System;
using System.Collections.Generic;

namespace Myra.Samples.TextBlocks
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var game = new TextBlocksGame())
                game.Run();            
        }
    }
}