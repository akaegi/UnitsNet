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
namespace UnitsNet.Extensions.NumberToPressure
{
    public static class NumberToPressureExtensions
    {
        /// <inheritdoc cref="Pressure.FromAtmospheres(UnitsNet.QuantityValue)" />
        public static Pressure Atmospheres<T>(this T value) => Pressure.FromAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromBars(UnitsNet.QuantityValue)" />
        public static Pressure Bars<T>(this T value) => Pressure.FromBars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromCentibars(UnitsNet.QuantityValue)" />
        public static Pressure Centibars<T>(this T value) => Pressure.FromCentibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecapascals(UnitsNet.QuantityValue)" />
        public static Pressure Decapascals<T>(this T value) => Pressure.FromDecapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecibars(UnitsNet.QuantityValue)" />
        public static Pressure Decibars<T>(this T value) => Pressure.FromDecibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromFeetOfHead(UnitsNet.QuantityValue)" />
        public static Pressure FeetOfHead<T>(this T value) => Pressure.FromFeetOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromGigapascals(UnitsNet.QuantityValue)" />
        public static Pressure Gigapascals<T>(this T value) => Pressure.FromGigapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromHectopascals(UnitsNet.QuantityValue)" />
        public static Pressure Hectopascals<T>(this T value) => Pressure.FromHectopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromInchesOfMercury(UnitsNet.QuantityValue)" />
        public static Pressure InchesOfMercury<T>(this T value) => Pressure.FromInchesOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilobars(UnitsNet.QuantityValue)" />
        public static Pressure Kilobars<T>(this T value) => Pressure.FromKilobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareCentimeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilogramsForcePerSquareMillimeter<T>(this T value) => Pressure.FromKilogramsForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareCentimeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure KilonewtonsPerSquareMillimeter<T>(this T value) => Pressure.FromKilonewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopascals(UnitsNet.QuantityValue)" />
        public static Pressure Kilopascals<T>(this T value) => Pressure.FromKilopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareFoot<T>(this T value) => Pressure.FromKilopoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        public static Pressure KilopoundsForcePerSquareInch<T>(this T value) => Pressure.FromKilopoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegabars(UnitsNet.QuantityValue)" />
        public static Pressure Megabars<T>(this T value) => Pressure.FromMegabars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMeganewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure MeganewtonsPerSquareMeter<T>(this T value) => Pressure.FromMeganewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegapascals(UnitsNet.QuantityValue)" />
        public static Pressure Megapascals<T>(this T value) => Pressure.FromMegapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMetersOfHead(UnitsNet.QuantityValue)" />
        public static Pressure MetersOfHead<T>(this T value) => Pressure.FromMetersOfHead(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicropascals(UnitsNet.QuantityValue)" />
        public static Pressure Micropascals<T>(this T value) => Pressure.FromMicropascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillibars(UnitsNet.QuantityValue)" />
        public static Pressure Millibars<T>(this T value) => Pressure.FromMillibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillimetersOfMercury(UnitsNet.QuantityValue)" />
        public static Pressure MillimetersOfMercury<T>(this T value) => Pressure.FromMillimetersOfMercury(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareCentimeter<T>(this T value) => Pressure.FromNewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareMeter<T>(this T value) => Pressure.FromNewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure NewtonsPerSquareMillimeter<T>(this T value) => Pressure.FromNewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPascals(UnitsNet.QuantityValue)" />
        public static Pressure Pascals<T>(this T value) => Pressure.FromPascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(UnitsNet.QuantityValue)" />
        public static Pressure PoundsForcePerSquareFoot<T>(this T value) => Pressure.FromPoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(UnitsNet.QuantityValue)" />
        public static Pressure PoundsForcePerSquareInch<T>(this T value) => Pressure.FromPoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(UnitsNet.QuantityValue)" />
        public static Pressure TechnicalAtmospheres<T>(this T value) => Pressure.FromTechnicalAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareCentimeter<T>(this T value) => Pressure.FromTonnesForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareMeter<T>(this T value) => Pressure.FromTonnesForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(UnitsNet.QuantityValue)" />
        public static Pressure TonnesForcePerSquareMillimeter<T>(this T value) => Pressure.FromTonnesForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTorrs(UnitsNet.QuantityValue)" />
        public static Pressure Torrs<T>(this T value) => Pressure.FromTorrs(Convert.ToDouble(value));

    }
}
#endif
