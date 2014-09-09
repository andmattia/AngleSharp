﻿namespace AngleSharp.DOM.Css
{
    /// <summary>
    /// Represents the CSS text-align property.
    /// </summary>
    public interface ICssTextAlignProperty : ICssProperty
    {
        /// <summary>
        /// Gets the selected horizontal alignment mode.
        /// </summary>
        HorizontalAlignment Align { get; }
    }
}