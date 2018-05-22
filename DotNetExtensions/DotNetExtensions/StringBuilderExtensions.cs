using System;
using System.Text;

namespace DotNetExtensions
{
    public static class StringBuilderExtensions
    {
        /// <summary>
        /// Appends the specified text to the string and adds a new line
        /// </summary>
        public static void AppendWithNewLine(this StringBuilder builder, string text)
        {
            builder.Append(text);
            builder.Append(Environment.NewLine);
        }

        /// <summary>
        /// Appends a tab and the specified text to the string and adds a new line
        /// </summary>
        public static void AppendWithNewTabbedLine(this StringBuilder builder, string text)
        {
            builder.AddTab();
            builder.Append(text);
            builder.Append(Environment.NewLine);
        }

        /// <summary>
        /// Appends a [tabCount] number of tabs and the specified text to the string
        /// and adds a new line
        /// </summary>
        public static void AppendWithTabsAndNewLine(this StringBuilder builder, int tabCount, string text)
        {
            builder.AddTabs(tabCount);
            builder.Append(text);
            builder.Append(Environment.NewLine);
        }

        /// <summary>
        /// Appends a tab and the specified text to the string and adds [newLines] number of lines
        /// </summary>
        public static void AppendWithNewTabbedLines(this StringBuilder builder, string text, int newLines)
        {
            builder.AddTab();
            builder.Append(text);
            if (newLines > 0)
            {
                for (int counter = 1; counter <= newLines; counter++)
                {
                    builder.Append(Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// Adds specified text to string and [newLines] number of lines
        /// </summary>
        public static void AppendWithNewLines(this StringBuilder builder, string text, int newLines)
        {
            builder.Append(text);
            if (newLines > 0)
            {
                for (int counter = 1; counter <= newLines; counter++)
                {
                    builder.Append(Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// Checks whether [value] exists and appends it to the string if there.
        /// </summary>
        public static void AppendIfThere(this StringBuilder builder, string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                builder.Append(value);
            }
        }

        /// <summary>
        /// Appends the string with a tab
        /// </summary>
        public static void AddTab(this StringBuilder builder)
        {
            builder.Append("\t");
        }

        /// <summary>
        /// Appends the string with [tabs] number of tabs
        /// </summary>
        public static void AddTabs(this StringBuilder builder, int tabs)
        {
            for (int counter = 1; counter <= tabs; counter++)
            {
                builder.Append("\t");
            }   
        }

        /// <summary>
        /// Appends the string with a new line
        /// </summary>
        public static void AddLine(this StringBuilder builder)
        {
            builder.Append(Environment.NewLine);
        }

        /// <summary>
        /// Appends the string with [text] enclosed in angle brackets
        /// </summary>
        public static void AppendWithAngleBrackets(this StringBuilder builder, string text)
        {
            builder.Append("[");
            builder.Append(text);
            builder.Append("]");
        }
    }
}
