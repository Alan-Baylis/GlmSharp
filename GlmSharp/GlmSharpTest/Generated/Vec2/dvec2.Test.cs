using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec2
{
    [TestFixture]
    public class DoubleVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec2(5);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new dvec2(-7.5d, 3.5d);
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
            }
            {
                var v = new dvec2(new dvec2(-5, 4.5d));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(4.5d, v.y);
            }
            {
                var v = new dvec2(new dvec3(-3, 4.5d, -8.5d));
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4.5d, v.y);
            }
            {
                var v = new dvec2(new dvec4(2.5d, 1.5d, -3.5d, -8));
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec2(-5, 3);
            Assert.AreEqual(-5, v[0]);
            Assert.AreEqual(3, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[0] = 1.0;
            Assert.AreEqual(1.0, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[0] = -9.5d;
            Assert.AreEqual(-9.5d, v[0]);
            v[1] = -8.5d;
            Assert.AreEqual(-8.5d, v[1]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[0] = -6.5d;
            Assert.AreEqual(-6.5d, v[0]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[0] = -4.5d;
            Assert.AreEqual(-4.5d, v[0]);
            v[0] = -3.5d;
            Assert.AreEqual(-3.5d, v[0]);
            v[1] = -2.5d;
            Assert.AreEqual(-2.5d, v[1]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[1] = -0.5d;
            Assert.AreEqual(-0.5d, v[1]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[1] = 1.5d;
            Assert.AreEqual(1.5d, v[1]);
            v[0] = 2.5d;
            Assert.AreEqual(2.5d, v[0]);
            v[0] = 3.5d;
            Assert.AreEqual(3.5d, v[0]);
            v[0] = 4.5d;
            Assert.AreEqual(4.5d, v[0]);
            v[1] = 5.5d;
            Assert.AreEqual(5.5d, v[1]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[0] = 9.5d;
            Assert.AreEqual(9.5d, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec2(-9, 9.5d);
            var vals = v.Values;
            Assert.AreEqual(-9, vals[0]);
            Assert.AreEqual(9.5d, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec2.Zero.x);
            Assert.AreEqual(0.0, dvec2.Zero.y);
            
            Assert.AreEqual(1.0, dvec2.Ones.x);
            Assert.AreEqual(1.0, dvec2.Ones.y);
            
            Assert.AreEqual(1.0, dvec2.UnitX.x);
            Assert.AreEqual(0.0, dvec2.UnitX.y);
            
            Assert.AreEqual(0.0, dvec2.UnitY.x);
            Assert.AreEqual(1.0, dvec2.UnitY.y);
            
            Assert.AreEqual(double.MaxValue, dvec2.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec2.MaxValue.y);
            
            Assert.AreEqual(double.MinValue, dvec2.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec2.MinValue.y);
            
            Assert.AreEqual(double.Epsilon, dvec2.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec2.Epsilon.y);
            
            Assert.AreEqual(double.NaN, dvec2.NaN.x);
            Assert.AreEqual(double.NaN, dvec2.NaN.y);
            
            Assert.AreEqual(double.NegativeInfinity, dvec2.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec2.NegativeInfinity.y);
            
            Assert.AreEqual(double.PositiveInfinity, dvec2.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec2(-7.5d, 1.0);
            var v2 = new dvec2(-7.5d, 1.0);
            var v3 = new dvec2(1.0, -7.5d);
            Assert.That(v1 == new dvec2(v1));
            Assert.That(v2 == new dvec2(v2));
            Assert.That(v3 == new dvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec2(-6.5d, 4.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec2.Parse(s0);
            var v1 = dvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec2.TryParse(s0, out v0);
            var b1 = dvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new dvec2(-9.5d, 3.5d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<dvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new dvec2(7.5d, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-6, -5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(2, -5.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(3.5d, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-8.5d, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-5.5d, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-4, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(9.5d, -2.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-2.5d, 4.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec2(-2, 7.5d);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new dvec2(6, -2.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(2, -0.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(4, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(-8, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(-3, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(7, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(3.5d, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(0.5d, 6.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(5.5d, 5.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec2(3, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new dvec2(-0.5d, -7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(-6, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(3.5d, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(-9.5d, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(8, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(2.5d, 7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(1.0, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(-8.5d, -7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(-1.5d, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec2(-5, 6.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new dvec2(4.5d, -4);
                var v1 = new dvec2(7, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(3.5d, -7.5d);
                var v1 = new dvec2(-4, -1.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-2, -7);
                var v1 = new dvec2(0.0, 4.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-4, -4.5d);
                var v1 = new dvec2(-2, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-6, -7.5d);
                var v1 = new dvec2(-1.5d, -0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-5.5d, 2.5d);
                var v1 = new dvec2(-9, -0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-2.5d, -2);
                var v1 = new dvec2(-6, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-7.5d, -5.5d);
                var v1 = new dvec2(1.0, 2.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(-1.5d, -9);
                var v1 = new dvec2(2.5d, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec2(1.5d, -9);
                var v1 = new dvec2(2.5d, 6.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new dvec2(8.5d, -4);
                var v1 = new dvec2(7, -7.5d);
                var v2 = new dvec2(2.5d, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(0.0, 9.5d);
                var v1 = new dvec2(7.5d, 5);
                var v2 = new dvec2(1.5d, -2.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(1.5d, 7);
                var v1 = new dvec2(-5.5d, -8);
                var v2 = new dvec2(-1.5d, 7.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(5, -8.5d);
                var v1 = new dvec2(6.5d, 1.0);
                var v2 = new dvec2(8, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(7.5d, 0.5d);
                var v1 = new dvec2(-1.5d, -5);
                var v2 = new dvec2(-5, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(7.5d, 9);
                var v1 = new dvec2(-8, 9);
                var v2 = new dvec2(-8, -2.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(-2.5d, -8.5d);
                var v1 = new dvec2(4, 9.5d);
                var v2 = new dvec2(7, -7.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(1.0, 5);
                var v1 = new dvec2(0.5d, -1);
                var v2 = new dvec2(-2, 3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(9.5d, -9);
                var v1 = new dvec2(8, 6.5d);
                var v2 = new dvec2(-9.5d, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec2(-7, 7.5d);
                var v1 = new dvec2(5, -1.5d);
                var v2 = new dvec2(-5.5d, 1.0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new dvec2(7.5d, -2.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(-2, -5.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(-9.5d, -3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(-5.5d, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(0.5d, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(7.5d, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(1.0, -8.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(9, -3.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(3.5d, 8.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec2(-9.5d, 0.0);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new dvec2(1.5d, 3);
                var v1 = new dvec2(6.5d, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(2, 9);
                var v1 = new dvec2(-0.5d, 0.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(1.0, 2.5d);
                var v1 = new dvec2(-1, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(-5.5d, -5);
                var v1 = new dvec2(0.5d, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(-6.5d, -6.5d);
                var v1 = new dvec2(3, 1.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(-3.5d, 9);
                var v1 = new dvec2(6, 3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(1.5d, -5.5d);
                var v1 = new dvec2(-9, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(-7, 1.5d);
                var v1 = new dvec2(5, -1.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(-4, -2);
                var v1 = new dvec2(-7.5d, 1.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec2(1.5d, 4);
                var v1 = new dvec2(9.5d, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new dvec2(-8.5d, -4);
                var v1 = new dvec2(-2.5d, -6.5d);
                var v2 = new dvec2(-9, -8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(-2.5d, -2.5d);
                var v1 = new dvec2(9, -9.5d);
                var v2 = new dvec2(8, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(5.5d, 0.0);
                var v1 = new dvec2(0.0, -6.5d);
                var v2 = new dvec2(4.5d, 2.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(-9.5d, 4);
                var v1 = new dvec2(7.5d, 9.5d);
                var v2 = new dvec2(-1, 0.0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(5, 0.5d);
                var v1 = new dvec2(-6, -9.5d);
                var v2 = new dvec2(-6, 2.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(-5.5d, -7);
                var v1 = new dvec2(7, -4);
                var v2 = new dvec2(-7.5d, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(-3.5d, 3);
                var v1 = new dvec2(-1.5d, -6.5d);
                var v2 = new dvec2(-3.5d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(5, -9.5d);
                var v1 = new dvec2(0.5d, -2);
                var v2 = new dvec2(9.5d, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(0.5d, -2);
                var v1 = new dvec2(7.5d, 4);
                var v2 = new dvec2(-9, -9.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec2(4, -8.5d);
                var v1 = new dvec2(3, -3.5d);
                var v2 = new dvec2(-7, -1.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new dvec2(0.5d, -8.5d);
                var v1 = new dvec2(6, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(8, -7.5d);
                var v1 = new dvec2(9, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(6, 0.5d);
                var v1 = new dvec2(-7.5d, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(-8.5d, 2.5d);
                var v1 = new dvec2(9, 1.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(-3, 2);
                var v1 = new dvec2(7, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(5, 6.5d);
                var v1 = new dvec2(-1.5d, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(2.5d, 7);
                var v1 = new dvec2(2, 7.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(8.5d, -6);
                var v1 = new dvec2(7, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(0.5d, 8);
                var v1 = new dvec2(4, -5.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec2(0.5d, -3);
                var v1 = new dvec2(8, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new dvec2(-4.5d, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(9.5d, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(-3, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(6.5d, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(-7, 9.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(-8, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(2.5d, -9.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(-5, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(-5.5d, 8.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec2(0.0, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(39197009);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec2.Random(random, -3, 0);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(757765011);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec2.RandomUniform(random, 1, 2);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1476333013);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec2.Random(random, -4, -2);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(47417368);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec2.RandomUniform(random, 1, 3);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1459892295);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec2.Random(random, -4, -1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

    }
}
