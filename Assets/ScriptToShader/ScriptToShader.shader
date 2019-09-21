Shader "Sample/ScriptToShader"
{
    Properties
    {
        _FloatValue("Float Value", Range(0, 1)) = 0
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

            float _FloatValue;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                return fixed4(_FloatValue, _FloatValue, _FloatValue, 1);
            }

            ENDCG
        }
    }
}