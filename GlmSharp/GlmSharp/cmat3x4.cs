using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    [Serializable]
    public struct cmat3x4 : IReadOnlyList<Complex>, IEquatable<cmat3x4>
    {
        // Matrix fields mXY
        public Complex m00, m01, m02, m03; // Column 0
        public Complex m10, m11, m12, m13; // Column 1
        public Complex m20, m21, m22, m23; // Column 2
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public Complex[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public Complex[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public cvec4 Column0 => new cvec4(m00, m01, m02, m03);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public cvec4 Column1 => new cvec4(m10, m11, m12, m13);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public cvec4 Column2 => new cvec4(m20, m21, m22, m23);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public cvec3 Row0 => new cvec3(m00, m10, m20);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public cvec3 Row1 => new cvec3(m01, m11, m21);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public cvec3 Row2 => new cvec3(m02, m12, m22);
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public cvec3 Row3 => new cvec3(m03, m13, m23);
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static cmat3x4 Zero { get; } = new cmat3x4(default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex), default(Complex));
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static cmat3x4 Ones { get; } = new cmat3x4(1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static cmat3x4 Identity { get; } = new cmat3x4(1.0, default(Complex), default(Complex), default(Complex), default(Complex), 1.0, default(Complex), default(Complex), default(Complex), default(Complex), 1.0, default(Complex));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cmat3x4(Complex m00, Complex m01, Complex m02, Complex m03, Complex m10, Complex m11, Complex m12, Complex m13, Complex m20, Complex m21, Complex m22, Complex m23)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public cmat3x4(cmat3x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public cmat3x4(cvec4 c0, cvec4 c1, cvec4 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m03;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m13;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m23;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of FieldCount (12).
        /// </summary>
        public int Count => 12;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m03;
                    case 4: return m10;
                    case 5: return m11;
                    case 6: return m12;
                    case 7: return m13;
                    case 8: return m20;
                    case 9: return m21;
                    case 10: return m22;
                    case 11: return m23;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m02 = value; break;
                    case 3: this.m03 = value; break;
                    case 4: this.m10 = value; break;
                    case 5: this.m11 = value; break;
                    case 6: this.m12 = value; break;
                    case 7: this.m13 = value; break;
                    case 8: this.m20 = value; break;
                    case 9: this.m21 = value; break;
                    case 10: this.m22 = value; break;
                    case 11: this.m23 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int col, int row]
        {
            get
            {
                return this[col * 4 + row];
            }
            set
            {
                this[col * 4 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(cmat3x4 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m03.Equals(rhs.m03) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m13.Equals(rhs.m13) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m22.Equals(rhs.m22) && m23.Equals(rhs.m23);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cmat3x4 && Equals((cmat3x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(cmat3x4 lhs, cmat3x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(cmat3x4 lhs, cmat3x4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m23.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public cmat4x3 Transposed => new cmat4x3(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public double Length => (double)Math.Sqrt(m00.LengthSqr() + m01.LengthSqr() + m02.LengthSqr() + m03.LengthSqr() + m10.LengthSqr() + m11.LengthSqr() + m12.LengthSqr() + m13.LengthSqr() + m20.LengthSqr() + m21.LengthSqr() + m22.LengthSqr() + m23.LengthSqr());
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public double LengthSqr => m00.LengthSqr() + m01.LengthSqr() + m02.LengthSqr() + m03.LengthSqr() + m10.LengthSqr() + m11.LengthSqr() + m12.LengthSqr() + m13.LengthSqr() + m20.LengthSqr() + m21.LengthSqr() + m22.LengthSqr() + m23.LengthSqr();
        
        /// <summary>
        /// Returns the sum of all FieldCount.
        /// </summary>
        public Complex Sum => m00 + m01 + m02 + m03 + m10 + m11 + m12 + m13 + m20 + m21 + m22 + m23;
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public double Norm => (double)Math.Sqrt(m00.LengthSqr() + m01.LengthSqr() + m02.LengthSqr() + m03.LengthSqr() + m10.LengthSqr() + m11.LengthSqr() + m12.LengthSqr() + m13.LengthSqr() + m20.LengthSqr() + m21.LengthSqr() + m22.LengthSqr() + m23.LengthSqr());
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public double Norm1 => m00.Magnitude + m01.Magnitude + m02.Magnitude + m03.Magnitude + m10.Magnitude + m11.Magnitude + m12.Magnitude + m13.Magnitude + m20.Magnitude + m21.Magnitude + m22.Magnitude + m23.Magnitude;
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(m00.LengthSqr() + m01.LengthSqr() + m02.LengthSqr() + m03.LengthSqr() + m10.LengthSqr() + m11.LengthSqr() + m12.LengthSqr() + m13.LengthSqr() + m20.LengthSqr() + m21.LengthSqr() + m22.LengthSqr() + m23.LengthSqr());
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public Complex NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00.Magnitude, m01.Magnitude), m02.Magnitude), m03.Magnitude), m10.Magnitude), m11.Magnitude), m12.Magnitude), m13.Magnitude), m20.Magnitude), m21.Magnitude), m22.Magnitude), m23.Magnitude);
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)m00.Magnitude, p) + Math.Pow((double)m01.Magnitude, p) + Math.Pow((double)m02.Magnitude, p) + Math.Pow((double)m03.Magnitude, p) + Math.Pow((double)m10.Magnitude, p) + Math.Pow((double)m11.Magnitude, p) + Math.Pow((double)m12.Magnitude, p) + Math.Pow((double)m13.Magnitude, p) + Math.Pow((double)m20.Magnitude, p) + Math.Pow((double)m21.Magnitude, p) + Math.Pow((double)m22.Magnitude, p) + Math.Pow((double)m23.Magnitude, p), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3x4 * cmat2x3 -> cmat2x4.
        /// </summary>
        public static cmat2x4 operator*(cmat3x4 lhs, cmat2x3 rhs) => new cmat2x4(lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01 + lhs.m20 * rhs.m02, lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m20 * rhs.m12, lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01 + lhs.m21 * rhs.m02, lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m21 * rhs.m12, lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01 + lhs.m22 * rhs.m02, lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m22 * rhs.m12, lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01 + lhs.m23 * rhs.m02, lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11 + lhs.m23 * rhs.m12);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3x4 * cmat3 -> cmat3x4.
        /// </summary>
        public static cmat3x4 operator*(cmat3x4 lhs, cmat3 rhs) => new cmat3x4(lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01 + lhs.m20 * rhs.m02, lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m20 * rhs.m12, lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21 + lhs.m20 * rhs.m22, lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01 + lhs.m21 * rhs.m02, lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m21 * rhs.m12, lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21 + lhs.m21 * rhs.m22, lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01 + lhs.m22 * rhs.m02, lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m22 * rhs.m12, lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21 + lhs.m22 * rhs.m22, lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01 + lhs.m23 * rhs.m02, lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11 + lhs.m23 * rhs.m12, lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21 + lhs.m23 * rhs.m22);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication cmat3x4 * cmat4x3 -> cmat4.
        /// </summary>
        public static cmat4 operator*(cmat3x4 lhs, cmat4x3 rhs) => new cmat4(lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01 + lhs.m20 * rhs.m02, lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11 + lhs.m20 * rhs.m12, lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21 + lhs.m20 * rhs.m22, lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31 + lhs.m20 * rhs.m32, lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01 + lhs.m21 * rhs.m02, lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11 + lhs.m21 * rhs.m12, lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21 + lhs.m21 * rhs.m22, lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31 + lhs.m21 * rhs.m32, lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01 + lhs.m22 * rhs.m02, lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11 + lhs.m22 * rhs.m12, lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21 + lhs.m22 * rhs.m22, lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31 + lhs.m22 * rhs.m32, lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01 + lhs.m23 * rhs.m02, lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11 + lhs.m23 * rhs.m12, lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21 + lhs.m23 * rhs.m22, lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31 + lhs.m23 * rhs.m32);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static cmat3x4 operator+(cmat3x4 lhs, cmat3x4 rhs) => new cmat3x4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat3x4 operator+(cmat3x4 lhs, Complex rhs) => new cmat3x4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static cmat3x4 operator+(Complex lhs, cmat3x4 rhs) => new cmat3x4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static cmat3x4 operator-(cmat3x4 lhs, cmat3x4 rhs) => new cmat3x4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat3x4 operator-(cmat3x4 lhs, Complex rhs) => new cmat3x4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static cmat3x4 operator-(Complex lhs, cmat3x4 rhs) => new cmat3x4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23);
    }
}