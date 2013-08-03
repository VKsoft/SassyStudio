﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SassyStudio.Compiler.Parsing
{
    class CppComment : Comment
    {
        public override bool Parse(IItemFactory itemFactory, ITextProvider text, ITokenStream stream)
        {
            if (stream.Current.Type == TokenType.CppComment)
            {
                OpenComment = Children.AddCurrentAndAdvance(stream, ClassifierType);

                if (stream.Current.Type == TokenType.CommentText)
                    CommentText = CloseComment = Children.AddCurrentAndAdvance(stream, ClassifierType);
            }

            return Children.Count > 0;
        }
    }
}
