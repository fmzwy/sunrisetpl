﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Igs.Hcms.Tmpl.Elements
{
    //Function Call
    internal  class FCall : Expression {
        private string name;
        private Expression[] args;

        public FCall(int line, int col, string name, Expression[] args)
        : base(line, col)
        {
            this.name = name;
            this.args = args;
        }

        public Expression[] Args
        {
            get {
                return this.args;
            }
        }

        public string Name
        {
            get {
                return this.name;
            }
        }

    }
}
