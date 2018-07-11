Shader "Sample/Sample02P"
{
    Properties
    {
        _GrayValue("Gray Scale Color", Range(0, 1)) = 0
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM

            #pragma vertex vert
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