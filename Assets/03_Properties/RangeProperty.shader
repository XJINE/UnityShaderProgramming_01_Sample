Shader "Sample/RangeProperty"
{
    Properties
    {
        _GrayValue("Gray Value", Range(0, 1)) = 0

        //_Vector("Vector Property", Vector) = (1, 0, 0, 1)
        //_Float ("Float Property",  Float)  = 1.0
        //_Int   ("Int Property",    Int)    = 0
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex   vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
            };

            fixed _GrayValue;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                return fixed4(_GrayValue, _GrayValue, _GrayValue, 1);
            }

            ENDCG
        }
    }
}