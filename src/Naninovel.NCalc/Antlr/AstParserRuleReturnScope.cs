﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Naninovel.Antlr.Runtime;

namespace Naninovel.Antlr.Runtime
{
    public class AstParserRuleReturnScope<TAstLabel, TToken> : ParserRuleReturnScope<TToken>,
        IAstRuleReturnScope<TAstLabel>
    {
        private TAstLabel _tree;

        public TAstLabel Tree
        {
            get { return _tree; }
            set { _tree = value; }
        }

        object IAstRuleReturnScope.Tree
        {
            get { return _tree; }
        }
    }
}
