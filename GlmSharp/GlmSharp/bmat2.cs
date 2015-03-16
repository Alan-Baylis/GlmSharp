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
    public struct bmat2 : IReadOnlyList<bool>, IEquatable<bmat2>
    {
        // Matrix fields mXY
        public bool m00, m01; // Column 0
        public bool m10, m11; // Column 1
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01 }, { m10, m11 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m10, m11 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public bvec2 Column0 => new bvec2(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public bvec2 Column1 => new bvec2(m10, m11);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public bvec2 Row0 => new bvec2(m00, m10);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public bvec2 Row1 => new bvec2(m01, m11);
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static bmat2 Zero { get; } = new bmat2(default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static bmat2 Ones { get; } = new bmat2(true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static bmat2 Identity { get; } = new bmat2(true, default(bool), default(bool), true);
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat2(bool m00, bool m01, bool m10, bool m11)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public bmat2(bmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public bmat2(bvec2 c0, bvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of FieldCount (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m10;
                    case 3: return m11;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m10 = value; break;
                    case 3: this.m11 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int col, int row]
        {
            get
            {
                return this[col * 2 + row];
            }
            set
            {
                this[col * 2 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat2 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat2 && Equals((bmat2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat2 lhs, bmat2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat2 lhs, bmat2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public bmat2 Transposed => new bmat2(m00, m10, m01, m11);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public bool MinElement => m00 && m01 && m10 && m11;
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public bool MaxElement => m00 || m01 || m10 || m11;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => m00 && m01 && m10 && m11;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => m00 || m01 || m10 || m11;
        
        /// <summary>
        /// Executes a component-wise &&. (sorry for different overload but && cannot be overloaded directly)
        /// </summary>
        public static bmat2 operator&(bmat2 lhs, bmat2 rhs) => new bmat2(lhs.m00 && rhs.m00, lhs.m01 && rhs.m01, lhs.m10 && rhs.m10, lhs.m11 && rhs.m11);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bmat2 operator|(bmat2 lhs, bmat2 rhs) => new bmat2(lhs.m00 || rhs.m00, lhs.m01 || rhs.m01, lhs.m10 || rhs.m10, lhs.m11 || rhs.m11);
    }
}