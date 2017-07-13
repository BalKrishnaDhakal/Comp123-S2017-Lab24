﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Bal Krishna Dhakal
 * Date: July 13, 2017
 * Description: This is the Abstract Human Class
 * Version: 0.1 - Created the Abstract Human Class
 */
namespace Comp123___S2017___Lab24
{/// <summary>
/// This is the abstract Human Class
/// </summary>
  public  abstract class Human
    {
        // PRIVATE INSTANCE VARIABLES(FIELDS)
        public String _name;

        //PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        // CONSTRUCTORS
        /// <summary>
        /// This is the main constructor of the Human Class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        // PRIVATE METHODS
        // public METHODS

    }
}