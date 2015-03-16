using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct decmat4x2 : IEnumerable<decimal>, IEquatable<decmat4x2>
    {
        // Matrix fields mXY
        public decimal m00, m01; // Column 0
        public decimal m10, m11; // Column 1
        public decimal m20, m21; // Column 2
        public decimal m30, m31; // Column 3
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public decimal[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 }, { m30, m31 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public decimal[] Values1D => new[] { m00, m01, m10, m11, m20, m21, m30, m31 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public decvec2 Column0 => new decvec2(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public decvec2 Column1 => new decvec2(m10, m11);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public decvec2 Column2 => new decvec2(m20, m21);
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public decvec2 Column3 => new decvec2(m30, m31);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public decvec4 Row0 => new decvec4(m00, m10, m20, m30);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public decvec4 Row1 => new decvec4(m01, m11, m21, m31);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x2 Zero = new decmat4x2(default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x2 Ones = new decmat4x2(1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x2 Identity = new decmat4x2(1m, default(decimal), default(decimal), 1m, default(decimal), default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decmat4x2(decimal m00, decimal m01, decimal m10, decimal m11, decimal m20, decimal m21, decimal m30, decimal m31)
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
        public decmat4x2(decmat4x2 m)
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
        public decmat4x2(decvec2 c0, decvec2 c1, decvec2 c2, decvec2 c3)
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
        public IEnumerator<decimal> GetEnumerator()
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
        public bool Equals(decmat4x2 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m30.Equals(rhs.m30) && m31.Equals(rhs.m31);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decmat4x2 && Equals((decmat4x2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(decmat4x2 lhs, decmat4x2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(decmat4x2 lhs, decmat4x2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode();
            }
        }
    }
}
