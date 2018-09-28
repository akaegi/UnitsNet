﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToAcceleration
{
    public static class NumberToAccelerationExtensions
    {
        /// <inheritdoc cref="Acceleration.FromCentimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration CentimetersPerSecondSquared<T>(this T value) => Acceleration.FromCentimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromDecimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration DecimetersPerSecondSquared<T>(this T value) => Acceleration.FromDecimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromFeetPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration FeetPerSecondSquared<T>(this T value) => Acceleration.FromFeetPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromInchesPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration InchesPerSecondSquared<T>(this T value) => Acceleration.FromInchesPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKilometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration KilometersPerSecondSquared<T>(this T value) => Acceleration.FromKilometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerHour(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerHour<T>(this T value) => Acceleration.FromKnotsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerMinute(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerMinute<T>(this T value) => Acceleration.FromKnotsPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromKnotsPerSecond(UnitsNet.QuantityValue)" />
        public static Acceleration KnotsPerSecond<T>(this T value) => Acceleration.FromKnotsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MetersPerSecondSquared<T>(this T value) => Acceleration.FromMetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMicrometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MicrometersPerSecondSquared<T>(this T value) => Acceleration.FromMicrometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromMillimetersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration MillimetersPerSecondSquared<T>(this T value) => Acceleration.FromMillimetersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromNanometersPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Acceleration NanometersPerSecondSquared<T>(this T value) => Acceleration.FromNanometersPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Acceleration.FromStandardGravity(UnitsNet.QuantityValue)" />
        public static Acceleration StandardGravity<T>(this T value) => Acceleration.FromStandardGravity(Convert.ToDouble(value));

    }
}
#endif
