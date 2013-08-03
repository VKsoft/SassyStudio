﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.Text.Classification;
using SassyStudio.Scss.Classifications;

namespace SassyStudio.Classification
{
    class ClassifierContext : IClassifierContext
    {
        readonly string Name;
        private IClassificationType ClassificationType;
        public ClassifierContext(SassClassifierType type)
        {
            Name = ResolveName(type);
        }

        public IClassificationType GetClassification(IClassificationTypeRegistryService registry)
        {
            if (ClassificationType == null)
                ClassificationType = registry.GetClassificationType(Name);

            return ClassificationType;
        }

        static string ResolveName(SassClassifierType type)
        {
            switch (type)
            {
                case SassClassifierType.Keyword: return ScssClassificationTypes.Keyword;
                case SassClassifierType.Comment: return ScssClassificationTypes.Comment;
                case SassClassifierType.UserFunctionDefinition: return ScssClassificationTypes.UserFunctionDefinition;
                case SassClassifierType.UserFunctionReference: return ScssClassificationTypes.UserFunctionReference;
                case SassClassifierType.MixinDefinition: return ScssClassificationTypes.MixinDefinition;
                case SassClassifierType.MixinReference: return ScssClassificationTypes.MixinReference;
                case SassClassifierType.VariableReference: return ScssClassificationTypes.VariableReference;
                case SassClassifierType.VariableDefinition: return ScssClassificationTypes.VariableDefinition;
                case SassClassifierType.ImportanceModifier: return ScssClassificationTypes.ImportanceModifier;
                case SassClassifierType.ParentReference: return ScssClassificationTypes.ParentReference;
                case SassClassifierType.Interpolation: return ScssClassificationTypes.Interpolation;
                case SassClassifierType.SystemFunction: return ScssClassificationTypes.FunctionReference;
                case SassClassifierType.String: return ScssClassificationTypes.StringValue;
                default: return "Default";
            }
        }
    }
}
