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

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class DecimalVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec3(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var v = new decvec3(-0.5m, 5, 0m);
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec2(7, 6));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec3(2.5m, 7.5m, -8));
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new decvec3(new decvec4(-6.5m, 0m, -7.5m, -2.5m));
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(-7.5m, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec3(-8, 6.5m, -6);
            Assert.AreEqual(-8, v[0]);
            Assert.AreEqual(6.5m, v[1]);
            Assert.AreEqual(-6, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            
            v[2] = 0m;
            Assert.AreEqual(0m, v[2]);
            v[0] = 1m;
            Assert.AreEqual(1m, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[2] = 9;
            Assert.AreEqual(9, v[2]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[2] = -9.5m;
            Assert.AreEqual(-9.5m, v[2]);
            v[1] = -8.5m;
            Assert.AreEqual(-8.5m, v[1]);
            v[2] = -7.5m;
            Assert.AreEqual(-7.5m, v[2]);
            v[1] = -6.5m;
            Assert.AreEqual(-6.5m, v[1]);
            v[1] = -5.5m;
            Assert.AreEqual(-5.5m, v[1]);
            v[1] = -4.5m;
            Assert.AreEqual(-4.5m, v[1]);
            v[0] = -3.5m;
            Assert.AreEqual(-3.5m, v[0]);
            v[1] = -2.5m;
            Assert.AreEqual(-2.5m, v[1]);
            v[0] = -1.5m;
            Assert.AreEqual(-1.5m, v[0]);
            v[2] = -0.5m;
            Assert.AreEqual(-0.5m, v[2]);
            v[1] = 0.5m;
            Assert.AreEqual(0.5m, v[1]);
            v[1] = 1.5m;
            Assert.AreEqual(1.5m, v[1]);
            v[0] = 2.5m;
            Assert.AreEqual(2.5m, v[0]);
            v[0] = 3.5m;
            Assert.AreEqual(3.5m, v[0]);
            v[1] = 4.5m;
            Assert.AreEqual(4.5m, v[1]);
            v[1] = 5.5m;
            Assert.AreEqual(5.5m, v[1]);
            v[2] = 6.5m;
            Assert.AreEqual(6.5m, v[2]);
            v[2] = 7.5m;
            Assert.AreEqual(7.5m, v[2]);
            v[1] = 8.5m;
            Assert.AreEqual(8.5m, v[1]);
            v[0] = 9.5m;
            Assert.AreEqual(9.5m, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new decvec3(-7, 7, 0.5m);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(7, vals[1]);
            Assert.AreEqual(0.5m, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0m, decvec3.Zero.x);
            Assert.AreEqual(0m, decvec3.Zero.y);
            Assert.AreEqual(0m, decvec3.Zero.z);
            
            Assert.AreEqual(1m, decvec3.Ones.x);
            Assert.AreEqual(1m, decvec3.Ones.y);
            Assert.AreEqual(1m, decvec3.Ones.z);
            
            Assert.AreEqual(1m, decvec3.UnitX.x);
            Assert.AreEqual(0m, decvec3.UnitX.y);
            Assert.AreEqual(0m, decvec3.UnitX.z);
            
            Assert.AreEqual(0m, decvec3.UnitY.x);
            Assert.AreEqual(1m, decvec3.UnitY.y);
            Assert.AreEqual(0m, decvec3.UnitY.z);
            
            Assert.AreEqual(0m, decvec3.UnitZ.x);
            Assert.AreEqual(0m, decvec3.UnitZ.y);
            Assert.AreEqual(1m, decvec3.UnitZ.z);
            
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.x);
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.y);
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.z);
            
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.x);
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.y);
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.z);
            
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.x);
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.y);
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new decvec3(-4.5m, 4.5m, 6);
            var v2 = new decvec3(-4.5m, 4.5m, 6);
            var v3 = new decvec3(6, 4.5m, -4.5m);
            Assert.That(v1 == new decvec3(v1));
            Assert.That(v2 == new decvec3(v2));
            Assert.That(v3 == new decvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new decvec3(-8.5m, 1m, -1);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = decvec3.Parse(s0);
            var v1 = decvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = decvec3.TryParse(s0, out v0);
            var b1 = decvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = decvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = decvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = decvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { decvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { decvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { decvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = decvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = decvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = decvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new decvec3(-7, 0m, -1);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new decvec3(0m, -1, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-0.5m, -0.5m, 0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(4.5m, 2, 4.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-5, 9, 0m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(0m, 8.5m, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-7, -6.5m, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(3, -4, 7.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-2.5m, 1.5m, -6.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-5, 6, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-6.5m, -5.5m, 3);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new decvec3(3, 4.5m, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-5, -7, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-6, -2.5m, 8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -7.5m, -9.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(7, -3.5m, -6.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(6, 9.5m, -4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-2, -2.5m, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-9, 5, 4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(5.5m, -5, -9.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-8.5m, -7, 7.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new decvec3(1.5m, -5, 3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-3.5m, -9.5m, -7.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-8.5m, -1.5m, -6.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-1, -8, 3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-2.5m, -2.5m, -1.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-2, -4.5m, -9.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(6, -3, 0m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(7, -2, 0.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(0.5m, 7.5m, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -3, 3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new decvec3(-3.5m, -3, -7);
                var v1 = new decvec3(5.5m, -9, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(1.5m, -8, -3);
                var v1 = new decvec3(1m, 7.5m, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-5, 1.5m, 5);
                var v1 = new decvec3(-4, 1m, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -3.5m, -2);
                var v1 = new decvec3(8.5m, 0.5m, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(4, -3, -9);
                var v1 = new decvec3(-2, -8, 9.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-1, 0m, -1.5m);
                var v1 = new decvec3(8.5m, -9.5m, -4.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-3, 9, -3);
                var v1 = new decvec3(8, -7, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-6, 4.5m, -5);
                var v1 = new decvec3(-9.5m, 4, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-2, 0m, 8);
                var v1 = new decvec3(-1.5m, -3, 1m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(9.5m, -2.5m, -7.5m);
                var v1 = new decvec3(6, 1.5m, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new decvec3(5.5m, -8.5m, -9.5m);
                var v1 = new decvec3(6, 4, 5.5m);
                var v2 = new decvec3(8.5m, -6, -5.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(7.5m, 5, 1.5m);
                var v1 = new decvec3(4, -4.5m, -7);
                var v2 = new decvec3(-0.5m, 2.5m, -3.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-3, 4, -6);
                var v1 = new decvec3(2.5m, 6.5m, 2);
                var v2 = new decvec3(-6.5m, -4.5m, -6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(3.5m, -0.5m, 9);
                var v1 = new decvec3(-8.5m, -4.5m, 6.5m);
                var v2 = new decvec3(-1.5m, -4.5m, 6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(3.5m, 4.5m, -9.5m);
                var v1 = new decvec3(-8.5m, 4, 5);
                var v2 = new decvec3(3, -8.5m, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4.5m, 1.5m, 4.5m);
                var v1 = new decvec3(-6, -5.5m, -3.5m);
                var v2 = new decvec3(-2, -1.5m, -6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4, 3, -4.5m);
                var v1 = new decvec3(-7, -5.5m, -9.5m);
                var v2 = new decvec3(-3, 4, -2.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4, -6, -8.5m);
                var v1 = new decvec3(4.5m, -7, 9.5m);
                var v2 = new decvec3(-8.5m, 6.5m, 7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(5, 2.5m, 9.5m);
                var v1 = new decvec3(-1, -1.5m, -5);
                var v2 = new decvec3(0m, 7.5m, 4.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-0.5m, -8, 4);
                var v1 = new decvec3(-5.5m, 9, 6.5m);
                var v2 = new decvec3(-3, -4, -7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new decvec3(4.5m, 4.5m, -5.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(9, 3.5m, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-7.5m, -3.5m, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(7, -2, -2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-6, 7.5m, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(6.5m, 6.5m, -1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-1.5m, -5.5m, 5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-9.5m, -3.5m, 1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(4.5m, -5.5m, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-8.5m, -3, -5.5m);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new decvec3(-1.5m, -1, 8);
                var v1 = new decvec3(4, -6, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-1.5m, -7, -1.5m);
                var v1 = new decvec3(-5.5m, -5.5m, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(8.5m, 2.5m, -6.5m);
                var v1 = new decvec3(-8.5m, -2.5m, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-2, -5, 5);
                var v1 = new decvec3(0m, 4.5m, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-7, -9, -4);
                var v1 = new decvec3(-8.5m, 0.5m, -5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-0.5m, 2, 2.5m);
                var v1 = new decvec3(0.5m, 0.5m, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(7.5m, -8, -6);
                var v1 = new decvec3(-0.5m, -8, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(2.5m, -3.5m, -9.5m);
                var v1 = new decvec3(-3, -0.5m, -7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(9.5m, -7.5m, -0.5m);
                var v1 = new decvec3(0m, -5, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-1.5m, -1.5m, -7);
                var v1 = new decvec3(2.5m, -1.5m, 7.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new decvec3(-6.5m, 6, -5);
                var v1 = new decvec3(8.5m, 5, -5.5m);
                var v2 = new decvec3(-0.5m, -1, -5.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-1.5m, 5.5m, 0m);
                var v1 = new decvec3(-8.5m, -6.5m, 6);
                var v2 = new decvec3(-3, 1.5m, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-2, -8.5m, -8);
                var v1 = new decvec3(7, -6.5m, -8);
                var v2 = new decvec3(-8.5m, 5.5m, -9.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(1m, 1m, 9.5m);
                var v1 = new decvec3(0m, 1m, -1.5m);
                var v2 = new decvec3(5.5m, -4, 8.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-8.5m, 0.5m, -2);
                var v1 = new decvec3(2, -0.5m, -4);
                var v2 = new decvec3(3, 4, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(7.5m, -8.5m, -4);
                var v1 = new decvec3(-3, 6, -9.5m);
                var v2 = new decvec3(-0.5m, -2, -2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(7, -6, -6.5m);
                var v1 = new decvec3(7.5m, -7, 9);
                var v2 = new decvec3(3, -1.5m, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-5.5m, -1.5m, 3.5m);
                var v1 = new decvec3(-2, -4.5m, 9);
                var v2 = new decvec3(8, 1.5m, 1m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(0.5m, 9, 1.5m);
                var v1 = new decvec3(3, 4, -9);
                var v2 = new decvec3(8.5m, -5.5m, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(6, -1.5m, 5.5m);
                var v1 = new decvec3(-9.5m, -1, 0.5m);
                var v2 = new decvec3(-7, -1.5m, 8.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new decvec3(-4, -7, -4.5m);
                var v1 = new decvec3(3.5m, -8.5m, -7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(5.5m, -4, -1);
                var v1 = new decvec3(1m, -9, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(-3, -8, 6.5m);
                var v1 = new decvec3(-1, -4.5m, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(2.5m, 2.5m, -7);
                var v1 = new decvec3(8.5m, -3.5m, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(6.5m, -6.5m, -8);
                var v1 = new decvec3(-4, 4, -1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(-2.5m, -8, 5);
                var v1 = new decvec3(0.5m, -9, 1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(3.5m, -8, 5);
                var v1 = new decvec3(-4, -2, 9.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(0.5m, -4, 1m);
                var v1 = new decvec3(9.5m, -8, 1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(0m, 6.5m, 5);
                var v1 = new decvec3(-1, 9.5m, 0m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(9.5m, -6, 0.5m);
                var v1 = new decvec3(6, 6.5m, 7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new decvec3(-1.5m, 3, -2.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-2.5m, 9.5m, 9.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(7.5m, 2.5m, 0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(7, 3, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-8, 2, -7.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-6.5m, -8.5m, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(2.5m, 5.5m, -0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(8.5m, -5.5m, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-6, 3.5m, -4.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(3, 7, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new decvec3(7, -1, -4);
                var v1 = new decvec3(-0.5m, 1m, 6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(2.5m, -4, 1.5m);
                var v1 = new decvec3(3, 5.5m, 4);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-7.5m, -8, -1.5m);
                var v1 = new decvec3(9, 5.5m, 1.5m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(9, 4, 8);
                var v1 = new decvec3(8, -0.5m, 9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(4.5m, 1.5m, -2);
                var v1 = new decvec3(1.5m, -5, 4);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-7, -2, -3);
                var v1 = new decvec3(-7, -3, -5);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-9.5m, -9, -3);
                var v1 = new decvec3(-4.5m, 8, 2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(5, -6.5m, 5.5m);
                var v1 = new decvec3(-4, 1m, 3.5m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-6.5m, -5.5m, -5);
                var v1 = new decvec3(-4, -6.5m, 2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-9.5m, 8.5m, -8.5m);
                var v1 = new decvec3(4, 4.5m, 9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(2032154041);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, 3, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(603238396);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomUniform(random, 2, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1321806398);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, -2, 1);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(2040374400);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomUniform(random, 3, 6);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1305365680);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, -2, 2);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

    }
}
