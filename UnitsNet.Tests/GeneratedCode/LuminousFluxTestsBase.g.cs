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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LuminousFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LuminousFluxTestsBase
    {
        protected abstract double LumensInOneLumen { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double LumensTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void LumenToLuminousFluxUnits()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(LumensInOneLumen, lumen.Lumens, LumensTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, LuminousFlux.From(1, LuminousFluxUnit.Lumen).Lumens, LumensTolerance);
        }

        [Fact]
        public void As()
        {
            var lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(LumensInOneLumen, lumen.As(LuminousFluxUnit.Lumen), LumensTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var lumen = LuminousFlux.FromLumens(1);

            var lumenQuantity = lumen.ToUnit(LuminousFluxUnit.Lumen);
            AssertEx.EqualTolerance(LumensInOneLumen, (double)lumenQuantity.Value, LumensTolerance);
            Assert.Equal(LuminousFluxUnit.Lumen, lumenQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(1, LuminousFlux.FromLumens(lumen.Lumens).Lumens, LumensTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LuminousFlux v = LuminousFlux.FromLumens(1);
            AssertEx.EqualTolerance(-1, -v.Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (LuminousFlux.FromLumens(3)-v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (v + v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(10, (v*10).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(10, (10*v).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, (LuminousFlux.FromLumens(10)/5).Lumens, LumensTolerance);
            AssertEx.EqualTolerance(2, LuminousFlux.FromLumens(10)/LuminousFlux.FromLumens(5), LumensTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LuminousFlux oneLumen = LuminousFlux.FromLumens(1);
            LuminousFlux twoLumens = LuminousFlux.FromLumens(2);

            Assert.True(oneLumen < twoLumens);
            Assert.True(oneLumen <= twoLumens);
            Assert.True(twoLumens > oneLumen);
            Assert.True(twoLumens >= oneLumen);

            Assert.False(oneLumen > twoLumens);
            Assert.False(oneLumen >= twoLumens);
            Assert.False(twoLumens < oneLumen);
            Assert.False(twoLumens <= oneLumen);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Equal(0, lumen.CompareTo(lumen));
            Assert.True(lumen.CompareTo(LuminousFlux.Zero) > 0);
            Assert.True(LuminousFlux.Zero.CompareTo(lumen) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Throws<ArgumentException>(() => lumen.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.Throws<ArgumentNullException>(() => lumen.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            LuminousFlux v = LuminousFlux.FromLumens(1);
            Assert.True(v.Equals(LuminousFlux.FromLumens(1), LumensTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(LuminousFlux.Zero, LumensTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.False(lumen.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LuminousFlux lumen = LuminousFlux.FromLumens(1);
            Assert.False(lumen.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(LuminousFluxUnit.Undefined, LuminousFlux.Units);
        }

    }
}
