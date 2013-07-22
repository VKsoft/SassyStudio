﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace SassyStudio.Scss.Classifications
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = ScssClassificationTypes.Comment)]
    [Name(ScssClassificationTypes.Comment)]
    [Order(After = Priority.Default)]
    [UserVisible(true)]
    sealed class ScssComment : ClassificationFormatDefinition
    {
        public ScssComment()
        {
            DisplayName = "SCSS Comment";
            ForegroundCustomizable = true;
        }
    }
}