using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_lvec4
    {
        public readonly long x;
        public readonly long y;
        public readonly long z;
        public readonly long w;
        
        public swizzle_lvec4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        public lvec4 xxxx => new lvec4(x, x, x, x);
        public lvec4 xxxy => new lvec4(x, x, x, y);
        public lvec4 xxxz => new lvec4(x, x, x, z);
        public lvec4 xxxw => new lvec4(x, x, x, w);
        public lvec3 xxx => new lvec3(x, x, x);
        public lvec4 xxyx => new lvec4(x, x, y, x);
        public lvec4 xxyy => new lvec4(x, x, y, y);
        public lvec4 xxyz => new lvec4(x, x, y, z);
        public lvec4 xxyw => new lvec4(x, x, y, w);
        public lvec3 xxy => new lvec3(x, x, y);
        public lvec4 xxzx => new lvec4(x, x, z, x);
        public lvec4 xxzy => new lvec4(x, x, z, y);
        public lvec4 xxzz => new lvec4(x, x, z, z);
        public lvec4 xxzw => new lvec4(x, x, z, w);
        public lvec3 xxz => new lvec3(x, x, z);
        public lvec4 xxwx => new lvec4(x, x, w, x);
        public lvec4 xxwy => new lvec4(x, x, w, y);
        public lvec4 xxwz => new lvec4(x, x, w, z);
        public lvec4 xxww => new lvec4(x, x, w, w);
        public lvec3 xxw => new lvec3(x, x, w);
        public lvec2 xx => new lvec2(x, x);
        public lvec4 xyxx => new lvec4(x, y, x, x);
        public lvec4 xyxy => new lvec4(x, y, x, y);
        public lvec4 xyxz => new lvec4(x, y, x, z);
        public lvec4 xyxw => new lvec4(x, y, x, w);
        public lvec3 xyx => new lvec3(x, y, x);
        public lvec4 xyyx => new lvec4(x, y, y, x);
        public lvec4 xyyy => new lvec4(x, y, y, y);
        public lvec4 xyyz => new lvec4(x, y, y, z);
        public lvec4 xyyw => new lvec4(x, y, y, w);
        public lvec3 xyy => new lvec3(x, y, y);
        public lvec4 xyzx => new lvec4(x, y, z, x);
        public lvec4 xyzy => new lvec4(x, y, z, y);
        public lvec4 xyzz => new lvec4(x, y, z, z);
        public lvec4 xyzw => new lvec4(x, y, z, w);
        public lvec3 xyz => new lvec3(x, y, z);
        public lvec4 xywx => new lvec4(x, y, w, x);
        public lvec4 xywy => new lvec4(x, y, w, y);
        public lvec4 xywz => new lvec4(x, y, w, z);
        public lvec4 xyww => new lvec4(x, y, w, w);
        public lvec3 xyw => new lvec3(x, y, w);
        public lvec2 xy => new lvec2(x, y);
        public lvec4 xzxx => new lvec4(x, z, x, x);
        public lvec4 xzxy => new lvec4(x, z, x, y);
        public lvec4 xzxz => new lvec4(x, z, x, z);
        public lvec4 xzxw => new lvec4(x, z, x, w);
        public lvec3 xzx => new lvec3(x, z, x);
        public lvec4 xzyx => new lvec4(x, z, y, x);
        public lvec4 xzyy => new lvec4(x, z, y, y);
        public lvec4 xzyz => new lvec4(x, z, y, z);
        public lvec4 xzyw => new lvec4(x, z, y, w);
        public lvec3 xzy => new lvec3(x, z, y);
        public lvec4 xzzx => new lvec4(x, z, z, x);
        public lvec4 xzzy => new lvec4(x, z, z, y);
        public lvec4 xzzz => new lvec4(x, z, z, z);
        public lvec4 xzzw => new lvec4(x, z, z, w);
        public lvec3 xzz => new lvec3(x, z, z);
        public lvec4 xzwx => new lvec4(x, z, w, x);
        public lvec4 xzwy => new lvec4(x, z, w, y);
        public lvec4 xzwz => new lvec4(x, z, w, z);
        public lvec4 xzww => new lvec4(x, z, w, w);
        public lvec3 xzw => new lvec3(x, z, w);
        public lvec2 xz => new lvec2(x, z);
        public lvec4 xwxx => new lvec4(x, w, x, x);
        public lvec4 xwxy => new lvec4(x, w, x, y);
        public lvec4 xwxz => new lvec4(x, w, x, z);
        public lvec4 xwxw => new lvec4(x, w, x, w);
        public lvec3 xwx => new lvec3(x, w, x);
        public lvec4 xwyx => new lvec4(x, w, y, x);
        public lvec4 xwyy => new lvec4(x, w, y, y);
        public lvec4 xwyz => new lvec4(x, w, y, z);
        public lvec4 xwyw => new lvec4(x, w, y, w);
        public lvec3 xwy => new lvec3(x, w, y);
        public lvec4 xwzx => new lvec4(x, w, z, x);
        public lvec4 xwzy => new lvec4(x, w, z, y);
        public lvec4 xwzz => new lvec4(x, w, z, z);
        public lvec4 xwzw => new lvec4(x, w, z, w);
        public lvec3 xwz => new lvec3(x, w, z);
        public lvec4 xwwx => new lvec4(x, w, w, x);
        public lvec4 xwwy => new lvec4(x, w, w, y);
        public lvec4 xwwz => new lvec4(x, w, w, z);
        public lvec4 xwww => new lvec4(x, w, w, w);
        public lvec3 xww => new lvec3(x, w, w);
        public lvec2 xw => new lvec2(x, w);
        public lvec4 yxxx => new lvec4(y, x, x, x);
        public lvec4 yxxy => new lvec4(y, x, x, y);
        public lvec4 yxxz => new lvec4(y, x, x, z);
        public lvec4 yxxw => new lvec4(y, x, x, w);
        public lvec3 yxx => new lvec3(y, x, x);
        public lvec4 yxyx => new lvec4(y, x, y, x);
        public lvec4 yxyy => new lvec4(y, x, y, y);
        public lvec4 yxyz => new lvec4(y, x, y, z);
        public lvec4 yxyw => new lvec4(y, x, y, w);
        public lvec3 yxy => new lvec3(y, x, y);
        public lvec4 yxzx => new lvec4(y, x, z, x);
        public lvec4 yxzy => new lvec4(y, x, z, y);
        public lvec4 yxzz => new lvec4(y, x, z, z);
        public lvec4 yxzw => new lvec4(y, x, z, w);
        public lvec3 yxz => new lvec3(y, x, z);
        public lvec4 yxwx => new lvec4(y, x, w, x);
        public lvec4 yxwy => new lvec4(y, x, w, y);
        public lvec4 yxwz => new lvec4(y, x, w, z);
        public lvec4 yxww => new lvec4(y, x, w, w);
        public lvec3 yxw => new lvec3(y, x, w);
        public lvec2 yx => new lvec2(y, x);
        public lvec4 yyxx => new lvec4(y, y, x, x);
        public lvec4 yyxy => new lvec4(y, y, x, y);
        public lvec4 yyxz => new lvec4(y, y, x, z);
        public lvec4 yyxw => new lvec4(y, y, x, w);
        public lvec3 yyx => new lvec3(y, y, x);
        public lvec4 yyyx => new lvec4(y, y, y, x);
        public lvec4 yyyy => new lvec4(y, y, y, y);
        public lvec4 yyyz => new lvec4(y, y, y, z);
        public lvec4 yyyw => new lvec4(y, y, y, w);
        public lvec3 yyy => new lvec3(y, y, y);
        public lvec4 yyzx => new lvec4(y, y, z, x);
        public lvec4 yyzy => new lvec4(y, y, z, y);
        public lvec4 yyzz => new lvec4(y, y, z, z);
        public lvec4 yyzw => new lvec4(y, y, z, w);
        public lvec3 yyz => new lvec3(y, y, z);
        public lvec4 yywx => new lvec4(y, y, w, x);
        public lvec4 yywy => new lvec4(y, y, w, y);
        public lvec4 yywz => new lvec4(y, y, w, z);
        public lvec4 yyww => new lvec4(y, y, w, w);
        public lvec3 yyw => new lvec3(y, y, w);
        public lvec2 yy => new lvec2(y, y);
        public lvec4 yzxx => new lvec4(y, z, x, x);
        public lvec4 yzxy => new lvec4(y, z, x, y);
        public lvec4 yzxz => new lvec4(y, z, x, z);
        public lvec4 yzxw => new lvec4(y, z, x, w);
        public lvec3 yzx => new lvec3(y, z, x);
        public lvec4 yzyx => new lvec4(y, z, y, x);
        public lvec4 yzyy => new lvec4(y, z, y, y);
        public lvec4 yzyz => new lvec4(y, z, y, z);
        public lvec4 yzyw => new lvec4(y, z, y, w);
        public lvec3 yzy => new lvec3(y, z, y);
        public lvec4 yzzx => new lvec4(y, z, z, x);
        public lvec4 yzzy => new lvec4(y, z, z, y);
        public lvec4 yzzz => new lvec4(y, z, z, z);
        public lvec4 yzzw => new lvec4(y, z, z, w);
        public lvec3 yzz => new lvec3(y, z, z);
        public lvec4 yzwx => new lvec4(y, z, w, x);
        public lvec4 yzwy => new lvec4(y, z, w, y);
        public lvec4 yzwz => new lvec4(y, z, w, z);
        public lvec4 yzww => new lvec4(y, z, w, w);
        public lvec3 yzw => new lvec3(y, z, w);
        public lvec2 yz => new lvec2(y, z);
        public lvec4 ywxx => new lvec4(y, w, x, x);
        public lvec4 ywxy => new lvec4(y, w, x, y);
        public lvec4 ywxz => new lvec4(y, w, x, z);
        public lvec4 ywxw => new lvec4(y, w, x, w);
        public lvec3 ywx => new lvec3(y, w, x);
        public lvec4 ywyx => new lvec4(y, w, y, x);
        public lvec4 ywyy => new lvec4(y, w, y, y);
        public lvec4 ywyz => new lvec4(y, w, y, z);
        public lvec4 ywyw => new lvec4(y, w, y, w);
        public lvec3 ywy => new lvec3(y, w, y);
        public lvec4 ywzx => new lvec4(y, w, z, x);
        public lvec4 ywzy => new lvec4(y, w, z, y);
        public lvec4 ywzz => new lvec4(y, w, z, z);
        public lvec4 ywzw => new lvec4(y, w, z, w);
        public lvec3 ywz => new lvec3(y, w, z);
        public lvec4 ywwx => new lvec4(y, w, w, x);
        public lvec4 ywwy => new lvec4(y, w, w, y);
        public lvec4 ywwz => new lvec4(y, w, w, z);
        public lvec4 ywww => new lvec4(y, w, w, w);
        public lvec3 yww => new lvec3(y, w, w);
        public lvec2 yw => new lvec2(y, w);
        public lvec4 zxxx => new lvec4(z, x, x, x);
        public lvec4 zxxy => new lvec4(z, x, x, y);
        public lvec4 zxxz => new lvec4(z, x, x, z);
        public lvec4 zxxw => new lvec4(z, x, x, w);
        public lvec3 zxx => new lvec3(z, x, x);
        public lvec4 zxyx => new lvec4(z, x, y, x);
        public lvec4 zxyy => new lvec4(z, x, y, y);
        public lvec4 zxyz => new lvec4(z, x, y, z);
        public lvec4 zxyw => new lvec4(z, x, y, w);
        public lvec3 zxy => new lvec3(z, x, y);
        public lvec4 zxzx => new lvec4(z, x, z, x);
        public lvec4 zxzy => new lvec4(z, x, z, y);
        public lvec4 zxzz => new lvec4(z, x, z, z);
        public lvec4 zxzw => new lvec4(z, x, z, w);
        public lvec3 zxz => new lvec3(z, x, z);
        public lvec4 zxwx => new lvec4(z, x, w, x);
        public lvec4 zxwy => new lvec4(z, x, w, y);
        public lvec4 zxwz => new lvec4(z, x, w, z);
        public lvec4 zxww => new lvec4(z, x, w, w);
        public lvec3 zxw => new lvec3(z, x, w);
        public lvec2 zx => new lvec2(z, x);
        public lvec4 zyxx => new lvec4(z, y, x, x);
        public lvec4 zyxy => new lvec4(z, y, x, y);
        public lvec4 zyxz => new lvec4(z, y, x, z);
        public lvec4 zyxw => new lvec4(z, y, x, w);
        public lvec3 zyx => new lvec3(z, y, x);
        public lvec4 zyyx => new lvec4(z, y, y, x);
        public lvec4 zyyy => new lvec4(z, y, y, y);
        public lvec4 zyyz => new lvec4(z, y, y, z);
        public lvec4 zyyw => new lvec4(z, y, y, w);
        public lvec3 zyy => new lvec3(z, y, y);
        public lvec4 zyzx => new lvec4(z, y, z, x);
        public lvec4 zyzy => new lvec4(z, y, z, y);
        public lvec4 zyzz => new lvec4(z, y, z, z);
        public lvec4 zyzw => new lvec4(z, y, z, w);
        public lvec3 zyz => new lvec3(z, y, z);
        public lvec4 zywx => new lvec4(z, y, w, x);
        public lvec4 zywy => new lvec4(z, y, w, y);
        public lvec4 zywz => new lvec4(z, y, w, z);
        public lvec4 zyww => new lvec4(z, y, w, w);
        public lvec3 zyw => new lvec3(z, y, w);
        public lvec2 zy => new lvec2(z, y);
        public lvec4 zzxx => new lvec4(z, z, x, x);
        public lvec4 zzxy => new lvec4(z, z, x, y);
        public lvec4 zzxz => new lvec4(z, z, x, z);
        public lvec4 zzxw => new lvec4(z, z, x, w);
        public lvec3 zzx => new lvec3(z, z, x);
        public lvec4 zzyx => new lvec4(z, z, y, x);
        public lvec4 zzyy => new lvec4(z, z, y, y);
        public lvec4 zzyz => new lvec4(z, z, y, z);
        public lvec4 zzyw => new lvec4(z, z, y, w);
        public lvec3 zzy => new lvec3(z, z, y);
        public lvec4 zzzx => new lvec4(z, z, z, x);
        public lvec4 zzzy => new lvec4(z, z, z, y);
        public lvec4 zzzz => new lvec4(z, z, z, z);
        public lvec4 zzzw => new lvec4(z, z, z, w);
        public lvec3 zzz => new lvec3(z, z, z);
        public lvec4 zzwx => new lvec4(z, z, w, x);
        public lvec4 zzwy => new lvec4(z, z, w, y);
        public lvec4 zzwz => new lvec4(z, z, w, z);
        public lvec4 zzww => new lvec4(z, z, w, w);
        public lvec3 zzw => new lvec3(z, z, w);
        public lvec2 zz => new lvec2(z, z);
        public lvec4 zwxx => new lvec4(z, w, x, x);
        public lvec4 zwxy => new lvec4(z, w, x, y);
        public lvec4 zwxz => new lvec4(z, w, x, z);
        public lvec4 zwxw => new lvec4(z, w, x, w);
        public lvec3 zwx => new lvec3(z, w, x);
        public lvec4 zwyx => new lvec4(z, w, y, x);
        public lvec4 zwyy => new lvec4(z, w, y, y);
        public lvec4 zwyz => new lvec4(z, w, y, z);
        public lvec4 zwyw => new lvec4(z, w, y, w);
        public lvec3 zwy => new lvec3(z, w, y);
        public lvec4 zwzx => new lvec4(z, w, z, x);
        public lvec4 zwzy => new lvec4(z, w, z, y);
        public lvec4 zwzz => new lvec4(z, w, z, z);
        public lvec4 zwzw => new lvec4(z, w, z, w);
        public lvec3 zwz => new lvec3(z, w, z);
        public lvec4 zwwx => new lvec4(z, w, w, x);
        public lvec4 zwwy => new lvec4(z, w, w, y);
        public lvec4 zwwz => new lvec4(z, w, w, z);
        public lvec4 zwww => new lvec4(z, w, w, w);
        public lvec3 zww => new lvec3(z, w, w);
        public lvec2 zw => new lvec2(z, w);
        public lvec4 wxxx => new lvec4(w, x, x, x);
        public lvec4 wxxy => new lvec4(w, x, x, y);
        public lvec4 wxxz => new lvec4(w, x, x, z);
        public lvec4 wxxw => new lvec4(w, x, x, w);
        public lvec3 wxx => new lvec3(w, x, x);
        public lvec4 wxyx => new lvec4(w, x, y, x);
        public lvec4 wxyy => new lvec4(w, x, y, y);
        public lvec4 wxyz => new lvec4(w, x, y, z);
        public lvec4 wxyw => new lvec4(w, x, y, w);
        public lvec3 wxy => new lvec3(w, x, y);
        public lvec4 wxzx => new lvec4(w, x, z, x);
        public lvec4 wxzy => new lvec4(w, x, z, y);
        public lvec4 wxzz => new lvec4(w, x, z, z);
        public lvec4 wxzw => new lvec4(w, x, z, w);
        public lvec3 wxz => new lvec3(w, x, z);
        public lvec4 wxwx => new lvec4(w, x, w, x);
        public lvec4 wxwy => new lvec4(w, x, w, y);
        public lvec4 wxwz => new lvec4(w, x, w, z);
        public lvec4 wxww => new lvec4(w, x, w, w);
        public lvec3 wxw => new lvec3(w, x, w);
        public lvec2 wx => new lvec2(w, x);
        public lvec4 wyxx => new lvec4(w, y, x, x);
        public lvec4 wyxy => new lvec4(w, y, x, y);
        public lvec4 wyxz => new lvec4(w, y, x, z);
        public lvec4 wyxw => new lvec4(w, y, x, w);
        public lvec3 wyx => new lvec3(w, y, x);
        public lvec4 wyyx => new lvec4(w, y, y, x);
        public lvec4 wyyy => new lvec4(w, y, y, y);
        public lvec4 wyyz => new lvec4(w, y, y, z);
        public lvec4 wyyw => new lvec4(w, y, y, w);
        public lvec3 wyy => new lvec3(w, y, y);
        public lvec4 wyzx => new lvec4(w, y, z, x);
        public lvec4 wyzy => new lvec4(w, y, z, y);
        public lvec4 wyzz => new lvec4(w, y, z, z);
        public lvec4 wyzw => new lvec4(w, y, z, w);
        public lvec3 wyz => new lvec3(w, y, z);
        public lvec4 wywx => new lvec4(w, y, w, x);
        public lvec4 wywy => new lvec4(w, y, w, y);
        public lvec4 wywz => new lvec4(w, y, w, z);
        public lvec4 wyww => new lvec4(w, y, w, w);
        public lvec3 wyw => new lvec3(w, y, w);
        public lvec2 wy => new lvec2(w, y);
        public lvec4 wzxx => new lvec4(w, z, x, x);
        public lvec4 wzxy => new lvec4(w, z, x, y);
        public lvec4 wzxz => new lvec4(w, z, x, z);
        public lvec4 wzxw => new lvec4(w, z, x, w);
        public lvec3 wzx => new lvec3(w, z, x);
        public lvec4 wzyx => new lvec4(w, z, y, x);
        public lvec4 wzyy => new lvec4(w, z, y, y);
        public lvec4 wzyz => new lvec4(w, z, y, z);
        public lvec4 wzyw => new lvec4(w, z, y, w);
        public lvec3 wzy => new lvec3(w, z, y);
        public lvec4 wzzx => new lvec4(w, z, z, x);
        public lvec4 wzzy => new lvec4(w, z, z, y);
        public lvec4 wzzz => new lvec4(w, z, z, z);
        public lvec4 wzzw => new lvec4(w, z, z, w);
        public lvec3 wzz => new lvec3(w, z, z);
        public lvec4 wzwx => new lvec4(w, z, w, x);
        public lvec4 wzwy => new lvec4(w, z, w, y);
        public lvec4 wzwz => new lvec4(w, z, w, z);
        public lvec4 wzww => new lvec4(w, z, w, w);
        public lvec3 wzw => new lvec3(w, z, w);
        public lvec2 wz => new lvec2(w, z);
        public lvec4 wwxx => new lvec4(w, w, x, x);
        public lvec4 wwxy => new lvec4(w, w, x, y);
        public lvec4 wwxz => new lvec4(w, w, x, z);
        public lvec4 wwxw => new lvec4(w, w, x, w);
        public lvec3 wwx => new lvec3(w, w, x);
        public lvec4 wwyx => new lvec4(w, w, y, x);
        public lvec4 wwyy => new lvec4(w, w, y, y);
        public lvec4 wwyz => new lvec4(w, w, y, z);
        public lvec4 wwyw => new lvec4(w, w, y, w);
        public lvec3 wwy => new lvec3(w, w, y);
        public lvec4 wwzx => new lvec4(w, w, z, x);
        public lvec4 wwzy => new lvec4(w, w, z, y);
        public lvec4 wwzz => new lvec4(w, w, z, z);
        public lvec4 wwzw => new lvec4(w, w, z, w);
        public lvec3 wwz => new lvec3(w, w, z);
        public lvec4 wwwx => new lvec4(w, w, w, x);
        public lvec4 wwwy => new lvec4(w, w, w, y);
        public lvec4 wwwz => new lvec4(w, w, w, z);
        public lvec4 wwww => new lvec4(w, w, w, w);
        public lvec3 www => new lvec3(w, w, w);
        public lvec2 ww => new lvec2(w, w);
    }
}
