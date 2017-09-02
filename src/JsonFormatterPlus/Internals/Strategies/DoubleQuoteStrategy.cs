﻿namespace JsonFormatterPlus.Internals.Strategies
{
    internal sealed class DoubleQuoteStrategy : ICharacterStrategy
    {
        public char ForWhichCharacter => '"';

        public void Execute(JsonFormatterStrategyContext context)
        {
            if (!context.IsProcessingSingleQuoteInitiatedString && !context.WasLastCharacterABackSlash)
            {
                context.IsProcessingDoubleQuoteInitiatedString = !context.IsProcessingDoubleQuoteInitiatedString;
            }

            context.AppendCurrentChar();
        }
    }
}
