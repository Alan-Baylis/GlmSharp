using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct lvec2 : IReadOnlyList<long>, IEquatable<lvec2>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public long y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_lvec2 swizzle => new swizzle_lvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 Zero = new lvec2(default(long), default(long));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 Ones = new lvec2(1, 1);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 UnitX = new lvec2(1, default(long));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 UnitY = new lvec2(default(long), 1);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public long[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lvec2(long x, long y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public lvec2(long v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Implicitly converts this to a decvec2.
        /// </summary>
        public static implicit operator decvec2(lvec2 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(lvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(lvec2 v) => new ivec3((int)v.x, (int)v.y, default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(lvec2 v) => new ivec4((int)v.x, (int)v.y, default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(lvec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(lvec2 v) => new uvec3((uint)v.x, (uint)v.y, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(lvec2 v) => new uvec4((uint)v.x, (uint)v.y, default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(lvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(lvec2 v) => new vec3((float)v.x, (float)v.y, default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(lvec2 v) => new vec4((float)v.x, (float)v.y, default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(lvec2 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(lvec2 v) => new dvec3((double)v.x, (double)v.y, default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(lvec2 v) => new dvec4((double)v.x, (double)v.y, default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(lvec2 v) => new decvec3((decimal)v.x, (decimal)v.y, default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(lvec2 v) => new decvec4((decimal)v.x, (decimal)v.y, default(decimal), default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(lvec2 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(lvec2 v) => new cvec3((Complex)v.x, (Complex)v.y, default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(lvec2 v) => new cvec4((Complex)v.x, (Complex)v.y, default(Complex), default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(lvec2 v) => new lvec3((long)v.x, (long)v.y, default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(lvec2 v) => new lvec4((long)v.x, (long)v.y, default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(lvec2 v) => new bvec2(v.x != default(long), v.y != default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(lvec2 v) => new bvec3(v.x != default(long), v.y != default(long), default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(lvec2 v) => new bvec4(v.x != default(long), v.y != default(long), default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return x;
            yield return y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(lvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lvec2 && Equals((lvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(lvec2 lhs, lvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(lvec2 lhs, lvec2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 397) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a boolean vector with component-wise equal.
        /// </summary>
        public static bvec2 Equal(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a boolean vector with component-wise not-equal.
        /// </summary>
        public static bvec2 NotEqual(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than.
        /// </summary>
        public static bvec2 GreaterThan(lvec2 lhs, lvec2 rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than-or-equal.
        /// </summary>
        public static bvec2 GreaterThanEqual(lvec2 lhs, lvec2 rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than.
        /// </summary>
        public static bvec2 LesserThan(lvec2 lhs, lvec2 rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than-or-equal.
        /// </summary>
        public static bvec2 LesserThanEqual(lvec2 lhs, lvec2 rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => x + sep + y;
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => x.ToString(provider) + sep + y.ToString(provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => x.ToString(format) + sep + y.ToString(format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => x.ToString(format, provider) + sep + y.ToString(format, provider);
        
        /// <summary>
        /// Predefined all-MaxValue vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 MaxValue = new lvec2(long.MaxValue, long.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector (DO NOT MODIFY)
        /// </summary>
        public static readonly lvec2 MinValue = new lvec2(long.MinValue, long.MinValue);
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static lvec2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static lvec2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new lvec2(long.Parse(kvp[0].Trim()), long.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static lvec2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new lvec2(long.Parse(kvp[0].Trim(), provider), long.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static lvec2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new lvec2(long.Parse(kvp[0].Trim(), style), long.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static lvec2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new lvec2(long.Parse(kvp[0].Trim(), style, provider), long.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out lvec2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out lvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            long x = default(long), y = default(long);
            var ok = long.TryParse(kvp[0].Trim(), out x) && long.TryParse(kvp[1].Trim(), out y);
            result = ok ? new lvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out lvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            long x = default(long), y = default(long);
            var ok = long.TryParse(kvp[0].Trim(), style, provider, out x) && long.TryParse(kvp[1].Trim(), style, provider, out y);
            result = ok ? new lvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public long MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public long MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x*x + y*y;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public long Sum => x + y;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => Math.Abs(x) + Math.Abs(y);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public long NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static lvec2 operator+(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lvec2 operator+(lvec2 lhs, long rhs) => new lvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static lvec2 operator+(long lhs, lvec2 rhs) => new lvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator+(lvec2 lhs, decvec2 rhs) => new decvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator+(decvec2 lhs, lvec2 rhs) => new decvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator+(lvec2 lhs, decimal rhs) => new decvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator+(decimal lhs, lvec2 rhs) => new decvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static lvec2 operator-(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lvec2 operator-(lvec2 lhs, long rhs) => new lvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static lvec2 operator-(long lhs, lvec2 rhs) => new lvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator-(lvec2 lhs, decvec2 rhs) => new decvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator-(decvec2 lhs, lvec2 rhs) => new decvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator-(lvec2 lhs, decimal rhs) => new decvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator-(decimal lhs, lvec2 rhs) => new decvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static lvec2 operator/(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lvec2 operator/(lvec2 lhs, long rhs) => new lvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static lvec2 operator/(long lhs, lvec2 rhs) => new lvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator/(lvec2 lhs, decvec2 rhs) => new decvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator/(decvec2 lhs, lvec2 rhs) => new decvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator/(lvec2 lhs, decimal rhs) => new decvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator/(decimal lhs, lvec2 rhs) => new decvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static lvec2 operator*(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lvec2 operator*(lvec2 lhs, long rhs) => new lvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static lvec2 operator*(long lhs, lvec2 rhs) => new lvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator*(lvec2 lhs, decvec2 rhs) => new decvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec2).
        /// </summary>
        public static decvec2 operator*(decvec2 lhs, lvec2 rhs) => new decvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator*(lvec2 lhs, decimal rhs) => new decvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec2).
        /// </summary>
        public static decvec2 operator*(decimal lhs, lvec2 rhs) => new decvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static lvec2 operator+(lvec2 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static lvec2 operator-(lvec2 v) => new lvec2(-v.x, -v.y);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static lvec2 operator%(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lvec2 operator%(lvec2 lhs, long rhs) => new lvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static lvec2 operator%(long lhs, lvec2 rhs) => new lvec2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static lvec2 operator^(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lvec2 operator^(lvec2 lhs, long rhs) => new lvec2(lhs.x ^ rhs, lhs.y ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static lvec2 operator^(long lhs, lvec2 rhs) => new lvec2(lhs ^ rhs.x, lhs ^ rhs.y);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static lvec2 operator|(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x | rhs.x, lhs.y | rhs.y);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lvec2 operator|(lvec2 lhs, long rhs) => new lvec2(lhs.x | rhs, lhs.y | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static lvec2 operator|(long lhs, lvec2 rhs) => new lvec2(lhs | rhs.x, lhs | rhs.y);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and).
        /// </summary>
        public static lvec2 operator&(lvec2 lhs, lvec2 rhs) => new lvec2(lhs.x & rhs.x, lhs.y & rhs.y);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static lvec2 operator&(lvec2 lhs, long rhs) => new lvec2(lhs.x & rhs, lhs.y & rhs);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static lvec2 operator&(long lhs, lvec2 rhs) => new lvec2(lhs & rhs.x, lhs & rhs.y);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static lvec2 operator<<(lvec2 lhs, int rhs) => new lvec2(lhs.x << rhs, lhs.y << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static lvec2 operator>>(lvec2 lhs, int rhs) => new lvec2(lhs.x >> rhs, lhs.y >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec2 operator<(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(lvec2 lhs, long rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(long lhs, lvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec2 operator<=(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(lvec2 lhs, long rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(long lhs, lvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec2 operator>(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(lvec2 lhs, long rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(long lhs, lvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec2 operator>=(lvec2 lhs, lvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(lvec2 lhs, long rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(long lhs, lvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec2 lhs, lvec2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec2 lhs, lvec2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec2 lhs, lvec2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static long Cross(lvec2 l, lvec2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => Math.Atan2((double)y, (double)x);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static lvec2 FromAngle(double angleInRad) => new lvec2((long)Math.Cos(angleInRad), (long)Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public lvec2 Rotated(double angleInRad) => (lvec2)(dvec2.FromAngle(Angle) * (double)Length);
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static lvec2 Abs(lvec2 v) => new lvec2(Math.Abs(v.x), Math.Abs(v.y));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static lvec2 Sqr(lvec2 v) => new lvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static lvec2 Pow2(lvec2 v) => new lvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static lvec2 Max(lvec2 lhs, lvec2 rhs) => new lvec2(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static lvec2 Max(lvec2 v, long s) => new lvec2(Math.Max(v.x, s), Math.Max(v.y, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static lvec2 Max(long s, lvec2 v) => new lvec2(Math.Max(s, v.x), Math.Max(s, v.y));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static lvec2 Min(lvec2 lhs, lvec2 rhs) => new lvec2(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static lvec2 Min(lvec2 v, long s) => new lvec2(Math.Min(v.x, s), Math.Min(v.y, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static lvec2 Min(long s, lvec2 v) => new lvec2(Math.Min(s, v.x), Math.Min(s, v.y));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static lvec2 Pow(lvec2 lhs, lvec2 rhs) => new lvec2((long)Math.Pow((double)lhs.x, (double)rhs.x), (long)Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static lvec2 Pow(lvec2 v, long s) => new lvec2((long)Math.Pow((double)v.x, (double)s), (long)Math.Pow((double)v.y, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static lvec2 Pow(long s, lvec2 v) => new lvec2((long)Math.Pow((double)s, (double)v.x), (long)Math.Pow((double)s, (double)v.y));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static lvec2 Log(lvec2 lhs, lvec2 rhs) => new lvec2((long)Math.Log((double)lhs.x, (double)rhs.x), (long)Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static lvec2 Log(lvec2 v, long s) => new lvec2((long)Math.Log((double)v.x, (double)s), (long)Math.Log((double)v.y, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static lvec2 Log(long s, lvec2 v) => new lvec2((long)Math.Log((double)s, (double)v.x), (long)Math.Log((double)s, (double)v.y));
    }
}
