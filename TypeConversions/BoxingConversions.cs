using System;
using Microsoft.VisualBasic.CompilerServices;
using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class BoxingConversions
    {
        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="object"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(Point point)
        {
            object valueBox = point;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="object"/> class.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(int value)
        {
            object valueBox = value;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="object"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object BoxToObject(Color color)
        {
            object valueBox = color;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Point point)
        {
            ValueType valueBox = point;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(int value)
        {
            ValueType valueBox = value;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="ValueType"/> class.
        /// </summary>
        /// <param name="color"><see cref="int"/> object.</param>
        /// <returns><see cref="ValueType"/> object.</returns>
        public static ValueType BoxToValueType(Color color)
        {
            ValueType valueBox = color;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Point"/> struct to <see cref="IColorable"/> interface.
        /// </summary>
        /// <param name="point"><see cref="Point"/> object.</param>
        /// <returns><see cref="IColorable"/> object.</returns>
        public static IColorable BoxToIColorable(Point point)
        {
            IColorable valueBox = point;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion build-in <see cref="int"/> struct to <see cref="IFormattable"/> interface.
        /// </summary>
        /// <param name="value"><see cref="int"/> object.</param>
        /// <returns><see cref="IFormattable"/> object.</returns>
        public static IFormattable BoxToIFormattable(int value)
        {
            IFormattable valueBox = value;
            return valueBox;
        }

        /// <summary>
        /// Performs an boxing conversion custom <see cref="Color"/> enum to <see cref="Enum"/> class.
        /// </summary>
        /// <param name="color"><see cref="Color"/> object.</param>
        /// <returns><see cref="Enum"/> object.</returns>
        public static Enum BoxToEnum(Color color)
        {
            Enum valueBox = color;
            return valueBox;
        }
    }
}
