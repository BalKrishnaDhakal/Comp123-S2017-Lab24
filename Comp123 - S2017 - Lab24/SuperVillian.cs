﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_S2017_Lab24
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // PRIVATE INSTANCE VARIABLES
        private int _malice;
        // PUBLIC PROPERTIES
        public int Malice
        {
            get
            {
                return this._malice;

            }
            set
            {
                this._malice = value;

            }
        }

        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperHuman class
        /// It takes one argument - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperVillian(string name, int malice)
            : base(name)
        {
            this.Malice = malice;

        }
        // PRIVATE METHODS
        // PUBLIC METHODS
    }
}