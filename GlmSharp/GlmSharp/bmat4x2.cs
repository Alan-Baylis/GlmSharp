using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct bmat4x2 : IEnumerable<bool>, IEquatable<bmat4x2>
    {
        // Matrix fields mXY
        public bool m00, m01; // Column 0
        public bool m10, m11; // Column 1
        public bool m20, m21; // Column 2
        public bool m30, m31; // Column 3
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 }, { m30, m31 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m10, m11, m20, m21, m30, m31 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public bvec2 Column0 => new bvec2(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public bvec2 Column1 => new bvec2(m10, m11);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public bvec2 Column2 => new bvec2(m20, m21);
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public bvec2 Column3 => new bvec2(m30, m31);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public bvec4 Row0 => new bvec4(m00, m10, m20, m30);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public bvec4 Row1 => new bvec4(m01, m11, m21, m31);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4x2 Zero = new bmat4x2(default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4x2 Ones = new bmat4x2(true, true, true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4x2 Identity = new bmat4x2(true, default(bool), default(bool), true, default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
            this.m20 = m20;
            this.m21 = m21;
            this.m30 = m30;
            this.m31 = m31;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public bmat4x2(bmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m30 = m.m30;
            this.m31 = m.m31;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public bmat4x2(bvec2 c0, bvec2 c1, bvec2 c2, bvec2 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m30 = c3.x;
            this.m31 = c3.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
            yield return m20;
            yield return m21;
            yield return m30;
            yield return m31;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat4x2 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m30.Equals(rhs.m30) && m31.Equals(rhs.m31);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat4x2 && Equals((bmat4x2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat4x2 lhs, bmat4x2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat4x2 lhs, bmat4x2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m20.GetHashCode()) * 2) ^ m21.GetHashCode()) * 2) ^ m30.GetHashCode()) * 2) ^ m31.GetHashCode();
            }
        }
    }
}
