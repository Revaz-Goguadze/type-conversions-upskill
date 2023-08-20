using System;
using TypeConversions.TypesForConversions;

namespace TypeConversions
{
    public static class ImplicitReferenceConversions
    {
        /// <summary>
        /// Performs an implicit conversion <see cref="Shape"/> type to <see cref="object"/> type.
        /// </summary>
        /// <param name="shape"><see cref="Shape"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object ConvertToObject(Shape shape)
        {
            object @object = shape;
            return @object;
        }

        /// <summary>
        /// Performs an implicit conversion <see cref="Circle"/> type to <see cref="object"/> type.
        /// </summary>
        /// <param name="circle"><see cref="Circle"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object ConvertToObject(Circle circle)
        {
            object @object = circle;
            return @object;
        }

        /// <summary>
        /// Performs an implicit conversion <see cref="Square"/> type to <see cref="object"/> type.
        /// </summary>
        /// <param name="square"><see cref="Square"/> object.</param>
        /// <returns><see cref="object"/> object.</returns>
        public static object ConvertToObject(Square square)
        {
            object @object = square;
            return @object;
        }

        /// <summary>
        /// Performs an implicit conversion <see cref="Circle"/> type to <see cref="Shape"/> type.
        /// </summary>
        /// <param name="circle"><see cref="Circle"/> object.</param>
        /// <returns><see cref="Shape"/> object.</returns>
        public static Shape ConvertToShape(Circle circle)
        {
            Shape shape = circle;
            return shape;
        }

        /// <summary>
        /// Performs an implicit conversion <see cref="Square"/> type to <see cref="Shape"/> type.
        /// </summary>
        /// <param name="square"><see cref="Square"/> object.</param>
        /// <returns><see cref="Shape"/> object.</returns>
        public static Shape ConvertToShape(Square square)
        {
            Shape shape = square;
            return shape;
        }

        /// <summary>
        /// Performs an implicit conversion <see cref="Square"/> type to <see cref="IColorable"/> type.
        /// </summary>
        /// <param name="square"><see cref="Square"/> object.</param>
        /// <returns><see cref="IColorable"/> object.</returns>
        public static IColorable ConvertToIColorable(Square square)
        {
            IColorable colorable = square;
            return colorable;
        }
    }
}
