﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
    {
    internal class Flyweight
        {
        static public void Main (String[] args)
            {
            string document = "AACCBBCB";
            char[] chars = document.ToCharArray();
            CharacterFactory factory = new CharacterFactory();
            // extrinsic state
            int pointSize = 10;
            // For each character use a flyweight object
            foreach ( char c in chars )
                {
                pointSize++;
                Character character = factory.GetCharacter(c);
                character.Display(pointSize);
                }
            // Wait for user
            Console.ReadKey();
            }
        }
    }
