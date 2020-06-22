namespace StaticPOO
{
    public static class Conversor
    {
        public static float CotacaoDolar = 5.23f;
        public static float CotacaoEuro = 5.9f;

        public static float ConverterDolarReal(float valor){
            return valor * CotacaoDolar;
        }

        public static float ConverterRealDolar(float valor){
            return valor / CotacaoDolar;
        }

        public static float ConverterEuroReal(float valor){
            return valor * CotacaoEuro;
        }

        public static float ConverterRealEuro(float valor){
            return valor / CotacaoEuro;
        }

    }
}